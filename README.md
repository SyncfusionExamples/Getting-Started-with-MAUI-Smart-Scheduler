# Getting Started with MAUI Smart Scheduler

This sample demonstrates how to get started with the .NET MAUI Smart Scheduler in a .NET MAUI application.

## Sample

```xaml
    <smartScheduler:SfSmartScheduler x:Name="smartScheduler"
                                     AppointmentsSource="{Binding Appointments}">
        <smartScheduler:SfSmartScheduler.AssistViewSettings>
            <smartScheduler:SchedulerAssistViewSettings SuggestedPrompts="{Binding SuggestedPrompts}"
                                                        ShowAssistViewBanner="True">
                <smartScheduler:SchedulerAssistViewSettings.AssistViewBannerTemplate>
                    <DataTemplate>
                        <Grid Margin="15" BackgroundColor="#E9EEFF">
                            <Label Text="Hi! I'm your personalized assistant.&#10;How can I help you?"
                                   HorizontalTextAlignment="Center" TextColor="#1C1B1F"
                                   FontSize="16" FontAttributes="Bold"/>
                        </Grid>
                    </DataTemplate>
                </smartScheduler:SchedulerAssistViewSettings.AssistViewBannerTemplate>
            </smartScheduler:SchedulerAssistViewSettings>
        </smartScheduler:SfSmartScheduler.AssistViewSettings>
    </smartScheduler:SfSmartScheduler>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.