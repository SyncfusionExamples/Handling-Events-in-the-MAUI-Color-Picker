# Handling-Events-in-the-MAUI-Color-Picker

This article explains how to handle events in the MAUI Color Picker control.

## Sample

```xaml
    <VerticalStackLayout Margin="50" Spacing="30">

        <!--ColorChanging Event -->
        <VerticalStackLayout>
            <Label Text="Color Changing Event" FontAttributes="Bold" />
            <inputs:SfColorPicker x:Name="colorPicker1" ColorChanging="OnColorChanging"/>
        </VerticalStackLayout>

        <!--ColorChanged Event -->
        <VerticalStackLayout>
            <Label Text="Color Changed Event" FontAttributes="Bold" />
            <inputs:SfColorPicker x:Name="colorPicker2" ColorChanged="OnColorChanged"/>
        </VerticalStackLayout>

        <!--ColorSelected Event -->
        <VerticalStackLayout >
            <Label Text="Color Selected Event" FontAttributes="Bold" />
            <Label x:Name="label" Text="Selected Color" TextColor="Black" 
                   HeightRequest="30" WidthRequest="150" BackgroundColor="LightGray"
                   HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
            <inputs:SfColorPicker x:Name="colorPicker3" Margin="0,10,0,0"
                                  ColorSelected="OnColorSelected"/>
        </VerticalStackLayout>

    </VerticalStackLayout>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples

