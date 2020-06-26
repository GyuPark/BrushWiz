//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Brush/Visualizer/WaveformParticles" {
Properties {
_TintColor ("Tint Color", Color) = (0.5,0.5,0.5,0.5)
_MainTex ("Particle Texture", 2D) = "white" { }
}
SubShader {
 Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
 Pass {
  Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
  ZWrite Off
  Cull Off
  GpuProgramID 20788
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER_CM" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "AUDIO_REACTIVE" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "AUDIO_REACTIVE" "ODS_RENDER_CM" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
}
}
}
}