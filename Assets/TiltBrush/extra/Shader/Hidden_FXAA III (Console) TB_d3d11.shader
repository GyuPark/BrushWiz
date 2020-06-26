//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/FXAA III (Console) TB" {
Properties {
_MainTex ("-", 2D) = "white" { }
_EdgeThresholdMin ("Edge threshold min", Float) = 0.125
_EdgeThreshold ("Edge Threshold", Float) = 0.25
_EdgeSharpness ("Edge sharpness", Float) = 4
}
SubShader {
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 6015
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