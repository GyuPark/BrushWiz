//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/SENaturalBloom FAST" {
Properties {
_MainTex ("Base (RGB)", 2D) = "white" { }
_Bloom0 ("Bloom0 (RGB)", 2D) = "black" { }
_Bloom1 ("Bloom1 (RGB)", 2D) = "black" { }
_Bloom2 ("Bloom2 (RGB)", 2D) = "black" { }
_Bloom3 ("Bloom3 (RGB)", 2D) = "black" { }
_Bloom4 ("Bloom4 (RGB)", 2D) = "black" { }
_Bloom5 ("Bloom5 (RGB)", 2D) = "black" { }
}
SubShader {
 Pass {
  ZTest Off
  ZWrite Off
  Cull Off
  GpuProgramID 44606
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Off
  ZWrite Off
  Cull Off
  GpuProgramID 107952
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Off
  ZWrite Off
  Cull Off
  GpuProgramID 184515
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Off
  ZWrite Off
  Cull Off
  GpuProgramID 226073
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
}
}
}
}