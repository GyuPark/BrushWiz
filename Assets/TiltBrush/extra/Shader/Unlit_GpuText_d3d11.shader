//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Unlit/GpuText" {
Properties {
_MainTex ("Text Texture", 2D) = "white" { }
_FontTex ("Font Texture", 2D) = "white" { }
_Offset ("Font character offset", Float) = 32
_FontWidth ("Font Characters across", Float) = 8
}
SubShader {
 LOD 100
 Tags { "RenderType" = "Opaque" }
 Pass {
  LOD 100
  Tags { "RenderType" = "Opaque" }
  GpuProgramID 60257
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