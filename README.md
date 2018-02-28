# Description
We are trying to add  [azure-iot-sdk's Azure.Devices.Client library](https://github.com/Azure/azure-iot-sdks) to our xamarin/MvvmCross application. This consists of a core NetStandard(2.0) library for shared functionality, and sperate projects for each native platform. We were able to get everything working in a UWP app, but have been experiencing a lot of issues with the android integration.
# Tools and Extensions that need to be up to date
- Visual Studio(15.5.7+)
- Visual Studio Tools for Xamarin(4.8.0.760)
- Xamarin Android SDK(8.1.5.0)
- Xamarin Templates(1.0.49)

# Xamarin-Forms Replication from scratch
1. Create a new Cross-Platform App(Xamarin.Forms) project: 
xf1
2. Select Blank App, Leave Android checked, and select .NET Standard, then click OK.
xf2 here
3. Build and deploy the application to verify it works in this state.
4. Add the nuget package Microsoft.Azure.Devices.Client(1.6.2) to the shared library.
5. Build and deploy again. The build is successful but it breaks during deployment.
xf3 and xf4 here

# MvvmCross Replication from example code
1. Open the project in visual studio
2. Build/Deploy the android application to verify that it's working correctly.
3. Open MvvmCross.Core.App.cs and uncomment lines # and #
4. Build and deploy again. Like the Xamarin-Forms example, the build is succesful but it breaks during deployment.

# Additional Notes
- If you configure the MVVMCross application to not ignore the bad referenced dependencies, you will be unable to add the Devices.Client package to the android application. The dependency that breaks the install is System.Threading.Overlapped. 
- You can reference it in the net standard library, but the build fails once it attempts to inject it into the android application. This throws the error:`Error Could not install package 'Microsoft.Azure.Devices 1.6.2'. You are trying to install this package into a project that targets 'MonoAndroid,Version=vx.x', but the package does not contain any assembly references or content files that are compatible with that framework`
