/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CoolProp {
  public static string get_global_param_string(string ParamName) {
    string ret = CoolPropPINVOKE.get_global_param_string(ParamName);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string get_fluid_param_string(string FluidName, string ParamName) {
    string ret = CoolPropPINVOKE.get_fluid_param_string(FluidName, ParamName);
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double PropsS(string Output, string Name1, double Prop1, string Name2, double Prop2, string Ref) {
    double ret = CoolPropPINVOKE.PropsS(Output, Name1, Prop1, Name2, Prop2, Ref);
    return ret;
  }

  public static double Props(string Output, char Name1, double Prop1, char Name2, double Prop2, string Ref) {
    double ret = CoolPropPINVOKE.Props(Output, Name1, Prop1, Name2, Prop2, Ref);
    return ret;
  }

  public static double Props1(string Ref, string Output) {
    double ret = CoolPropPINVOKE.Props1(Ref, Output);
    return ret;
  }

  public static double IProps(int iOutput, int iName1, double Prop1, int iName2, double Prop2, int iFluid) {
    double ret = CoolPropPINVOKE.IProps(iOutput, iName1, Prop1, iName2, Prop2, iFluid);
    return ret;
  }

  public static int IsFluidType(string Ref, string Type) {
    int ret = CoolPropPINVOKE.IsFluidType(Ref, Type);
    return ret;
  }

  public static double DerivTerms(string Term, double T, double rho, string Ref) {
    double ret = CoolPropPINVOKE.DerivTerms(Term, T, rho, Ref);
    return ret;
  }

  public static int Phase(string Fluid, double T, double p, string Phase_str) {
    int ret = CoolPropPINVOKE.Phase(Fluid, T, p, Phase_str);
    return ret;
  }

  public static int Phase_Trho(string Fluid, double T, double p, string Phase_str) {
    int ret = CoolPropPINVOKE.Phase_Trho(Fluid, T, p, Phase_str);
    return ret;
  }

  public static int Phase_Tp(string Fluid, double T, double rho, string Phase_str) {
    int ret = CoolPropPINVOKE.Phase_Tp(Fluid, T, rho, Phase_str);
    return ret;
  }

  public static void set_phase(string Phase_str) {
    CoolPropPINVOKE.set_phase(Phase_str);
  }

  public static double F2K(double T_F) {
    double ret = CoolPropPINVOKE.F2K(T_F);
    return ret;
  }

  public static double K2F(double T) {
    double ret = CoolPropPINVOKE.K2F(T);
    return ret;
  }

  public static int get_param_index(string param) {
    int ret = CoolPropPINVOKE.get_param_index(param);
    return ret;
  }

  public static int get_Fluid_index(string param) {
    int ret = CoolPropPINVOKE.get_Fluid_index(param);
    return ret;
  }

  public static int get_index_units(int param, string units) {
    int ret = CoolPropPINVOKE.get_index_units(param, units);
    return ret;
  }

  public static double rhosatL_anc(string Fluid, double T) {
    double ret = CoolPropPINVOKE.rhosatL_anc(Fluid, T);
    return ret;
  }

  public static double rhosatV_anc(string Fluid, double T) {
    double ret = CoolPropPINVOKE.rhosatV_anc(Fluid, T);
    return ret;
  }

  public static double psatL_anc(string Fluid, double T) {
    double ret = CoolPropPINVOKE.psatL_anc(Fluid, T);
    return ret;
  }

  public static double psatV_anc(string Fluid, double T) {
    double ret = CoolPropPINVOKE.psatV_anc(Fluid, T);
    return ret;
  }

  public static bool enable_TTSE_LUT(string FluidName) {
    bool ret = CoolPropPINVOKE.enable_TTSE_LUT(FluidName);
    return ret;
  }

  public static bool isenabled_TTSE_LUT(string FluidName) {
    bool ret = CoolPropPINVOKE.isenabled_TTSE_LUT(FluidName);
    return ret;
  }

  public static bool disable_TTSE_LUT(string FluidName) {
    bool ret = CoolPropPINVOKE.disable_TTSE_LUT(FluidName);
    return ret;
  }

  public static bool enable_TTSE_LUT_writing(string FluidName) {
    bool ret = CoolPropPINVOKE.enable_TTSE_LUT_writing(FluidName);
    return ret;
  }

  public static bool isenabled_TTSE_LUT_writing(string FluidName) {
    bool ret = CoolPropPINVOKE.isenabled_TTSE_LUT_writing(FluidName);
    return ret;
  }

  public static bool disable_TTSE_LUT_writing(string FluidName) {
    bool ret = CoolPropPINVOKE.disable_TTSE_LUT_writing(FluidName);
    return ret;
  }

  public static bool set_TTSESat_LUT_size(string FluidName, int arg1) {
    bool ret = CoolPropPINVOKE.set_TTSESat_LUT_size(FluidName, arg1);
    return ret;
  }

  public static bool set_TTSESinglePhase_LUT_size(string FluidName, int Np, int Nh) {
    bool ret = CoolPropPINVOKE.set_TTSESinglePhase_LUT_size(FluidName, Np, Nh);
    return ret;
  }

  public static bool set_TTSESinglePhase_LUT_range(string FluidName, double hmin, double hmax, double pmin, double pmax) {
    bool ret = CoolPropPINVOKE.set_TTSESinglePhase_LUT_range(FluidName, hmin, hmax, pmin, pmax);
    return ret;
  }

  public static bool get_TTSESinglePhase_LUT_range(string FluidName, SWIGTYPE_p_double hmin, SWIGTYPE_p_double hmax, SWIGTYPE_p_double pmin, SWIGTYPE_p_double pmax) {
    bool ret = CoolPropPINVOKE.get_TTSESinglePhase_LUT_range(FluidName, SWIGTYPE_p_double.getCPtr(hmin), SWIGTYPE_p_double.getCPtr(hmax), SWIGTYPE_p_double.getCPtr(pmin), SWIGTYPE_p_double.getCPtr(pmax));
    return ret;
  }

  public static int set_TTSE_mode(string FluidName, string Value) {
    int ret = CoolPropPINVOKE.set_TTSE_mode(FluidName, Value);
    return ret;
  }

  public static int set_reference_stateS(string Ref, string reference_state) {
    int ret = CoolPropPINVOKE.set_reference_stateS(Ref, reference_state);
    return ret;
  }

  public static int set_reference_stateD(string Ref, double T, double rho, double h0, double s0) {
    int ret = CoolPropPINVOKE.set_reference_stateD(Ref, T, rho, h0, s0);
    return ret;
  }

  public static int get_standard_unit_system() {
    int ret = CoolPropPINVOKE.get_standard_unit_system();
    return ret;
  }

  public static void set_standard_unit_system(int val) {
    CoolPropPINVOKE.set_standard_unit_system(val);
  }

  public static double viscosity_dilute(string FluidName, double T) {
    double ret = CoolPropPINVOKE.viscosity_dilute(FluidName, T);
    return ret;
  }

  public static double viscosity_residual(string FluidName, double T, double rho) {
    double ret = CoolPropPINVOKE.viscosity_residual(FluidName, T, rho);
    return ret;
  }

  public static double conductivity_critical(string FluidName, double T, double rho) {
    double ret = CoolPropPINVOKE.conductivity_critical(FluidName, T, rho);
    return ret;
  }

  public static double conductivity_background(string FluidName, double T, double rho) {
    double ret = CoolPropPINVOKE.conductivity_background(FluidName, T, rho);
    return ret;
  }

  public static double conformal_Trho(string FluidName, string ReferenceFluidName, double T, double rho, SWIGTYPE_p_double Tconform, SWIGTYPE_p_double rhoconform) {
    double ret = CoolPropPINVOKE.conformal_Trho(FluidName, ReferenceFluidName, T, rho, SWIGTYPE_p_double.getCPtr(Tconform), SWIGTYPE_p_double.getCPtr(rhoconform));
    return ret;
  }

  public static double HAProps(string OutputName, string Input1Name, double Input1, string Input2Name, double Input2, string Input3Name, double Input3) {
    double ret = CoolPropPINVOKE.HAProps(OutputName, Input1Name, Input1, Input2Name, Input2, Input3Name, Input3);
    return ret;
  }

  public static double HAProps_Aux(string OutputName, double T, double p, double W, string units) {
    double ret = CoolPropPINVOKE.HAProps_Aux(OutputName, T, p, W, units);
    return ret;
  }

  public static double IceProps(string Name, double T, double p) {
    double ret = CoolPropPINVOKE.IceProps(Name, T, p);
    return ret;
  }

  public static void UseVirialCorrelations(int flag) {
    CoolPropPINVOKE.UseVirialCorrelations(flag);
  }

  public static void UseIsothermCompressCorrelation(int flag) {
    CoolPropPINVOKE.UseIsothermCompressCorrelation(flag);
  }

  public static void UseIdealGasEnthalpyCorrelations(int flag) {
    CoolPropPINVOKE.UseIdealGasEnthalpyCorrelations(flag);
  }

  public static void HAHelp() {
    CoolPropPINVOKE.HAHelp();
  }

  public static int returnHumAirCode(string Code) {
    int ret = CoolPropPINVOKE.returnHumAirCode(Code);
    return ret;
  }

  public static double cair_sat(double T) {
    double ret = CoolPropPINVOKE.cair_sat(T);
    return ret;
  }

}
