package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("MVVMTransferDataTrofimov.MainApplication, MVVMTransferDataTrofimov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc645cdc2a91a7acd14f.MainApplication.class, crc645cdc2a91a7acd14f.MainApplication.__md_methods);
		mono.android.Runtime.register ("Microsoft.Maui.MauiApplication, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc6488302ad6e9e4df1a.MauiApplication.class, crc6488302ad6e9e4df1a.MauiApplication.__md_methods);
		
	}
}
