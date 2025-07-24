# Handling-Events-in-the-MAUI-Color-Picker

This article explains how to handle events in the MAUI Color Picker control.

## Sample

```xaml
    <tabView:SfTabView x:Name="tabView" TabBarPlacement="Top">
    <tabView:SfTabView.Items>
        <!--Color Changing event-->
        <tabView:SfTabItem Header="Color Changing" FontAttributes="Bold">
            <tabView:SfTabItem.Content>
                <VerticalStackLayout Margin="40">
                    <inputs:SfColorPicker x:Name="colorPicker1" ColorChanging="OnColorChanging"/>
                </VerticalStackLayout>
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <!--Color Changed event-->
        <tabView:SfTabItem Header="Color Changed" FontAttributes="Bold">
            <tabView:SfTabItem.Content>
                <VerticalStackLayout Margin="40">
                    <inputs:SfColorPicker x:Name="colorPicker2" ColorChanged="OnColorChanged"/>
                </VerticalStackLayout>
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <!--Color Selected event-->
        <tabView:SfTabItem Header="Color Selected" FontAttributes="Bold">
            <tabView:SfTabItem.Content>
                <Grid RowDefinitions="20,80" Margin="40">
                    <Label x:Name="label" Grid.Row="0" Text="Selected Color" TextColor="Black" 
                           HeightRequest="30" WidthRequest="150" BackgroundColor="LightGray"
                           HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
                    <inputs:SfColorPicker x:Name="colorPicker" Grid.Row="1" 
                                          ColorSelected="OnColorSelected"/>
                </Grid>
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
    </tabView:SfTabView.Items>
</tabView:SfTabView>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples

