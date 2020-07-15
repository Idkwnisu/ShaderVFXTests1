void Parallax(float2 UV, float3 ViewDir, float scale, float layers, Texture2D HeightMap, SamplerState SS, out float2 PUV)
{
float layerDepth = 1.0 / layers;

float currentLayerDepth = 0.0;
   
float2 P = ViewDir.xy * scale; 
float2 deltaTexCoords = P / layers;

float2  currentTexCoords     = UV;
float currentDepthMapValue = SAMPLE_TEXTURE2D(HeightMap, SS, currentTexCoords).r;
  
float count = 0;
while(currentLayerDepth < currentDepthMapValue && count < 100)
{
 count = count + 1;
    // shift texture coordinates along direction of P
    currentTexCoords += deltaTexCoords;
    // get depthmap value at current texture coordinates
    currentDepthMapValue =  SAMPLE_TEXTURE2D(HeightMap, SS, currentTexCoords).r;
    // get depth of next layer
    currentLayerDepth += layerDepth;  
}

float2 prevTexCoords = currentTexCoords + deltaTexCoords;

// get depth after and before collision for linear interpolation
float afterDepth  = currentDepthMapValue + currentLayerDepth; //change this to minus if you change to minus the delta
float beforeDepth = SAMPLE_TEXTURE2D(HeightMap, SS, prevTexCoords).r - currentLayerDepth + layerDepth;
 
// interpolation of texture coordinates
float weight = afterDepth / (afterDepth - beforeDepth);
float2 finalTexCoords = prevTexCoords * weight + currentTexCoords * (1.0 - weight);

PUV = finalTexCoords; 
}
