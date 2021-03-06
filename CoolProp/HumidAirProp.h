

#ifndef HUMAIR_H
#define HUMAIR_H

#if defined(COOLPROP_LIB)
	#define EXPORT_CODE extern "C" __declspec(dllexport)
	#ifndef CONVENTION
		#define CONVENTION __stdcall
	#endif
	#else
        #ifndef EXPORT_CODE
            #if defined(EXTERNC)
                #define EXPORT_CODE extern "C"
            #else
                #define EXPORT_CODE
            #endif
        #endif
		#ifndef CONVENTION
			#define CONVENTION
		#endif
	#endif

	// Hack for PowerPC compilation to only use extern "C"
	#if defined(__powerpc__) || defined(EXTERNC)
	#define EXPORT_CODE extern "C"
	#endif

    // Hack for PowerPC compilation to only use extern "C"
#if defined(__powerpc__) || defined(EXTERNC)
#define EXPORT_CODE extern "C"
#endif


// -----------------------
// Standard I/O function
// -----------------------
EXPORT_CODE double CONVENTION HAProps(char *OutputName, char *Input1Name, double Input1, char *Input2Name, double Input2, char *Input3Name, double Input3);

// -----------------------
// Extra I/O function
// -----------------------
EXPORT_CODE double CONVENTION HAProps_Aux(char* OutputName, double T, double p, double W, char *units);

// Properties for Ice Ih at temperatures below 273.16 K
double IceProps(char* Name, double T, double p);

//Turn on the use of virial correlations for air and water
void UseVirialCorrelations(int flag);
void UseIsothermCompressCorrelation(int flag);
void UseIdealGasEnthalpyCorrelations(int flag);

// --------------
// Help functions
// --------------
void HAHelp(void);
int returnHumAirCode(char * Code);

// ----------------------
// Other simple functions
// ----------------------
double cair_sat(double T);

#endif
