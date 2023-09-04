# Customize-the-appearance-of-the.NET-MAUI-ListView-control
This sample demonstrate how to customize the appearance of the .NET MAUI ListView control by using different templates.

A quick-start example to help you how to customize the appearance of the .NET MAUI ListView control by using different templates.

Watch the video: https://www.youtube.com/watch?v=qp4MglFU0q4&t=1s

Documentation: https://help.syncfusion.com/maui/listview/viewappearance

## XAML
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             xmlns:local="clr-namespace:Appearance_MAUI_ListView"
             x:Class="Appearance_MAUI_ListView.MainPage">
    <ContentPage.BindingContext>
        <local:ContactInfoRepo />
    </ContentPage.BindingContext>
    <ContentPage.Resources>
        <DataTemplate x:Key="NormalTemplate">
            <Grid Margin="2">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="60"/>
                    <ColumnDefinition Width="*"/>
                </Grid.ColumnDefinitions>
                <Image Grid.Column="0"  Source="{Binding ContactImage}" HeightRequest="40" WidthRequest="40" HorizontalOptions="Start"/>
                <StackLayout Grid.Column="1" >
                    <Label Text="{Binding ContactName}" VerticalOptions="Center" FontSize="16"/>
                    <Label  Text="{Binding ContactNumber}" VerticalOptions="Center" FontSize="12"/>
                </StackLayout>
            </Grid>
        </DataTemplate>
        <DataTemplate x:Key="MissedCallTemplate">
            <Grid Margin="2">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="60"/>
                    <ColumnDefinition Width="*"/>
                </Grid.ColumnDefinitions>
                <Image Grid.Column="0"  Source="{Binding ContactImage}" HeightRequest="40" WidthRequest="40" HorizontalOptions="Start"/>
                <StackLayout Grid.Column="1" >
                    <Label Text="{Binding ContactName}" VerticalOptions="Center" FontSize="16"/>
                    <Label  Text="{Binding ContactNumber}" TextColor="Red" VerticalOptions="Center" FontSize="12"/>
                </StackLayout>
            </Grid>
        </DataTemplate>
        <local:ContactInfoDataTemplateSelector x:Key="templateSelector"
                                               NormalTemplate="{StaticResource NormalTemplate}"
                                               MissedCallTemplate="{StaticResource MissedCallTemplate}" />
        <local:IndexToColorConverter x:Key="IndexToColorConverter"/>
    </ContentPage.Resources>
    <ContentPage.Content>
        <syncfusion:SfListView x:Name="listView"  
                               SelectionMode="None"
                               ItemsSource="{Binding Contacts}" 
                               ItemTemplate="{StaticResource templateSelector}">
        </syncfusion:SfListView>
    </ContentPage.Content>
</ContentPage>

## C#
internal class ContactInfoDataTemplateSelector : DataTemplateSelector
	{
		public DataTemplate NormalTemplate { get; set; }
		public DataTemplate MissedCallTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var contact = (ContactInfo)item;
			if(contact != null)
			{
				if (contact.IsMissed)
					return MissedCallTemplate;
				else
					return NormalTemplate;
			}

			return NormalTemplate;
		}
	}
    
## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

To run the sample demo, refer to [System Requirements for .NET MAUI.](https://help.syncfusion.com/maui/system-requirements)

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.