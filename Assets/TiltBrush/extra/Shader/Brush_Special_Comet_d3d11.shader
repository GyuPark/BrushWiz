//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Brush/Special/Comet" {
Properties {
_MainTex ("Texture", 2D) = "white" { }
_AlphaMask ("Alpha Mask", 2D) = "white" { }
_Speed ("Animation Speed", Range(0, 1)) = 1
_EmissionGain ("Emission Gain", Range(0, 1)) = 0.5
}
SubShader {
 Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
 Pass {
  Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
  ZWrite Off
  Cull Off
  GpuProgramID 15552
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER_CM" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" "SELECTION_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" "SELECTION_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER_CM" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "ODS_RENDER" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "ODS_RENDER_CM" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "SELECTION_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER" "SELECTION_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER_CM" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER_CM" "SELECTION_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER_CM" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SELECTION_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" "SELECTION_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" "SELECTION_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER_CM" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "ODS_RENDER" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "ODS_RENDER_CM" "SELECTION_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "SELECTION_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER" "SELECTION_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER_CM" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER_CM" "SELECTION_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
}
}
}
}