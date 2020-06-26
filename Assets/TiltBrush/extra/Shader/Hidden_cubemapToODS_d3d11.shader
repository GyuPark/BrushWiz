//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/cubemapToODS" {
Properties {
_MainTex ("Cubemap", Cube) = "black" { }
_LeftTex ("Cubemap", Cube) = "black" { }
}
SubShader {
 LOD 100
 Tags { "RenderType" = "Opaque" }
 Pass {
  LOD 100
  Tags { "RenderType" = "Opaque" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 8442
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "VR_180" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ANAGLYPH" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "VR_180" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ANAGLYPH" }
"// shader disassembly not supported on DXBC"
}
}
}
}
}