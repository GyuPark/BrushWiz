//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/PinCushionItem" {
Properties {
_ActivatedColor ("Main Color", Color) = (1,1,1,1)
_MainTex ("Texture", 2D) = "white" { }
}
SubShader {
 Tags { "QUEUE" = "AlphaTest+20" }
 Pass {
  Tags { "QUEUE" = "AlphaTest+20" }
  GpuProgramID 64287
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_SIMPLE" }
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
SubProgram "d3d11 " {
Keywords { "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
}
}
}
Fallback "Transparent/Cutout/VertexLit"
}