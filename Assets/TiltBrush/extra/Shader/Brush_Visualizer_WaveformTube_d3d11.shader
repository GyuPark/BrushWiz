//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Brush/Visualizer/WaveformTube" {
Properties {
_MainTex ("Particle Texture", 2D) = "white" { }
_EmissionGain ("Emission Gain", Range(0, 1)) = 0.5
}
SubShader {
 Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
 Pass {
  Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
  ZWrite Off
  Cull Off
  GpuProgramID 7716
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "HDR_EMULATED" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "HDR_EMULATED" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "ODS_RENDER" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "ODS_RENDER_CM" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "HDR_EMULATED" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "HDR_EMULATED" "ODS_RENDER" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_EMULATED" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "HDR_EMULATED" "ODS_RENDER_CM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "ODS_RENDER" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ODS_RENDER_CM" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SOFTPARTICLES_ON" "ODS_RENDER_CM" "HDR_SIMPLE" }
"// shader disassembly not supported on DXBC"
}
}
}
}
}