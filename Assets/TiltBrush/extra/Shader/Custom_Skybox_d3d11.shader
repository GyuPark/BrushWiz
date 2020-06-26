//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/Skybox" {
Properties {
_Tint ("Tint Color", Color) = (0.5,0.5,0.5,0.5)
_Exposure ("Exposure", Range(0, 8)) = 1
_SkyboxRotation ("Skybox rotation", Vector) = (0,0,0,1)
_Tex ("Cubemap   (HDR)", Cube) = "grey" { }
}
SubShader {
 Tags { "PreviewType" = "Skybox" "QUEUE" = "Background" "RenderType" = "Background" }
 Pass {
  Tags { "PreviewType" = "Skybox" "QUEUE" = "Background" "RenderType" = "Background" }
  ZWrite Off
  Cull Off
  GpuProgramID 20719
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
}
}