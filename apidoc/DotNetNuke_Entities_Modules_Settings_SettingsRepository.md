---
uid: DotNetNuke.Entities.Modules.Settings.SettingsRepository`1
summary: 'The SettingsRepository is used to persist settings to one of DNNs internal settings stores'
remarks: *content
---

The SettingsRepository allows you to write concise classes for persisting
settings to either ModuleSettings, TabModuleSettings or PortalSettings.
All you need to do is to implement a static retrieval method (GetSettings in the sample below)
and a storage method (SaveSettings below) on a Repository that is typed to
your class (MyModuleSettingsRepository below). You can then label each settings
you need by providing the right attribute to each property.

#### Setting up the settings class

```cs
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Settings;

public class MyModuleSettings
{
    [ModuleSetting]
    public int Foo { get; set; } = -1;
    [ModuleSetting]
    public string Bar { get; set; } = "My default string";
    [TabModuleSetting]
    public bool Baz { get; set; } = true;

    public static MyModuleSettings GetSettings(ModuleInfo module)
    {
        var repo = new MyModuleSettingsRepository();
        return repo.GetSettings(module);
    }

    public void SaveSettings(ModuleInfo module)
    {
        var repo = new MyModuleSettingsRepository();
        repo.SaveSettings(module, this);
    }
}

public class MyModuleSettingsRepository : SettingsRepository<MyModuleSettings>
{
}
```

#### Consuming the settings in your module

Once you have the settings class you can use this anywhere in your code. The most
powerful way is to add this to a base class underlying your front end code. If working in
an MVC type scenario you could create a class that inherits from DnnController
(e.g. MyModuleController) that your controllers inherit from:

```cs
public class HomeController : MyModuleController
```

Then, in MyModuleController you could add the following snippet:

```cs
private MyModuleSettings _settings;
public MyModuleSettings Settings
{
    get { return _settings ?? (_settings = MyModuleSettings.GetSettings(ModuleContext.Configuration)); }
}
```

Now in any of your controllers you can access these settings using `Settings.Foo` and `Settings.Bar`, etc. You can use a similar approach for the WebPage/WebPage<T> to get
the same syntax in your razor files. This will declutter your front end code. A more
extensive example can be found in this module which implements this:

[https://github.com/DNN-Connect/Conference](https://github.com/DNN-Connect/Conference)

