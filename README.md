Android Virtual Device Manager (Android Studio 3.6.3) vm:JDK 64-bit
===================================================================

Virtual Device Configuration
----------------------------

### System Image

-   Release: Pie

-   API Level: 28 (lowest is 19, Unity \> Player Settings \> Other \>
    Identification \> Min API Level)

-   ABI: x86 (x86_64, Unity \> Player Settings \> Other \> Configuration \>
    Scripting Backend \> IL2CPP)

-   Target: Android 9.0 ( lowest is Android 4.x, based on Min API Level above)

![](media/2fbc575b1fd033b8978f477156063a51.png)

### Hardware (note Resolution \#x\# for Unity Game Resolution see Unity section)

![](media/17ec7b9cabc1eb7a97b62da1a1ab809b.png)

3D Project (Unity 2019.3.13f1 Personal \<DX11\>)
================================================

File \> Build Setting
---------------------

-   Switch Platform: Android (defaults to PC, Mac & Linux Standalone)

-   Add Open Scenes: Scenes/\<Your Scene. (defaults to Scenes/SampleScene)

-   Run Device: All compatible devices (default device, will also show you
    running Android VDMs)

-   Player Settings: Click this to configure Android options next.

-   Build App Bundle (Google Play): …. In the future we’ll use this for multiple
    build configurations

![](media/7fc62c51da7c45844b8ee6788c7aee9d.png)

Player Settings (Android)
-------------------------

*Notes:*

-   *Company Name and Product Name (will be combined to make Package Name)
    com.kdtix.appname*

-   *Version is used by Google Play as unique upgrade paths for customers each
    time we publish our APK files for tests or prod*

### Player

-   Company Name: KDTIX

-   Product Name: hand-and-foot

-   Version: 0.000000001a ( Each time you upload you APK file to Google Dev
    Portal, increment it)

-   Default Icon: Your Application Icon – Texture, Type “Sprite (2D and UI)” png
    image file

-   Default Cursor: In-Game Cursor – Texture, Type “Cursor”, Alpha Transparent,
    Format RBGA 32

### Resolution and Presentation

-   Allowed Orientations for Auto Rotation (deselect what you wish not to
    support)

![](media/5cd2dc77c012905b45cfcff202d75735.png)

![](media/7fc0d56f44d6df1b55a802a2094006b7.png)

![](media/52f9b35fadf17cebcd15b5d09f3b72c2.png)

![](media/2af10d2605ad0a6631620c6f6019c317.png)

![](media/ae9f4b9576cd44db962648d2ae22c0e6.png)
