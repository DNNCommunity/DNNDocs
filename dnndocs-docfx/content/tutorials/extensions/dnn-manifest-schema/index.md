---
uid: dnn-manifest-schema
locale: en
title: The DNN Manifest Schema
dnnversion: 09.02.00
related-topics: persona-bar-style-guide,theme-objects,requirements,dnn-overview,dnn-overview,control-bar-to-persona-bar,persona-bar-by-role,more-resources,module-features,module-architecture,developers-creating-modules-overview,about-evs
links: ["[DNN UX Guide](https://uxguide.dnnsoftware.com/)","[Top 5 DotNetNuke Manifest file Module Packaging Tips by Bruce Chapman](https://web.archive.org/web/20160610221847/http://www.ifinity.com.au/Blog/EntryId/89/Top-5-DotNetNuke-Manifest-file-Module-Packaging-Tips)","[DNN Community blog: DAL 2 — A New DotNetNuke Data Layer for a New Decade by Charles Nurse](https://www.dnnsoftware.com/community-blog/cid/142201/dal-2-a-new-dotnetnuke-data-layer-for-a-new-decade)","[DNN Wiki: Manifests](https://www.dnnsoftware.com/wiki/manifests)","[DNN Community blog: The New Extension Installer Manifest — Part 1, Introduction by Charles Nurse](https://www.dnnsoftware.com/community-blog/cid/135060/the-new-extension-installer-manifest-part-1-introduction)","[DNN Module APIs](https://www.dnnsoftware.com/dnn-api/)","[Top 5 DotNetNuke Manifest file Module Packaging Tips by Bruce Chapman](https://web.archive.org/web/20160610221847/http://www.ifinity.com.au/Blog/EntryId/89/Top-5-DotNetNuke-Manifest-file-Module-Packaging-Tips)","[DNN Community blog: DAL 2 — A New DotNetNuke Data Layer for a New Decade by Charles Nurse](https://www.dnnsoftware.com/community-blog/cid/142201/dal-2-a-new-dotnetnuke-data-layer-for-a-new-decade)","[DNN Wiki: Manifests](https://www.dnnsoftware.com/wiki/manifests)","[DNN Community blog: The New Extension Installer Manifest — Part 1, Introduction by Charles Nurse](https://www.dnnsoftware.com/community-blog/cid/135060/the-new-extension-installer-manifest-part-1-introduction)"]
---

# The DNN Manifest Schema

The DNN **manifest** is an XML file (e.g., **MyDNNExtension.dnn**) that indicates how specific files in the extension package must be processed during installation.

Only the files specifically declared in the manifest would be installed. Files inside any zip file specified in `component type="ResourceFile"` do not have to be listed individually. Nonexistent files mentioned in the manifest will cause an error message.

The manifest file extension must be `.dnn`. You can add the DNN version at the end; e.g., `MyDNNExtension.dnn7`.

Save the manifest file in the base folder of your package and include it when zipping your package files.

## Schema

```

    <dotnetnuke type="Package" version="8.0">
        <packages>
            <package name="MyCompany.SampleModule" type="Module" version="1.0.0">
                <friendlyName>My Sample Module</friendlyName>
                <description>My Sample Module is a demonstration module.</description>
                <iconFile>MyIcon.png</iconFile>
                <owner>
                    <name>MyCompany or MyName</name>
                    <organization>MyCompany Corporation</organization>
                    <url>www.example.com</url>
                    <email>support@example.com</email>
                </owner>
                <license src="MyLicense.txt" />
                <releaseNotes src="MyReleaseNotes.txt" />
                <azureCompatible>true</azureCompatible>
                <dependencies>
                    <dependency type="coreVersion">08.00.00</dependency>
                    ...
                </dependencies>
                <components>
                    <component type="Module">
                        ...
                    </component>
                    ...
                </components>
            </package>
        </packages>
    </dotnetnuke>

```

## package

```

    <package name="MyCompany.MySampleModule" type="Module" version="1.0.0">
    ...
    </package>

```

*   *name* must be unique. To ensure your package's uniqueness, add your company as the prefix.
*   *type* can be one of the following:
    *   `Auth_System`
    *   `Container`
    *   `CoreLanguagePack`
    *   [DashboardControl](https://www.dnnsoftware.com/wiki/manifest-dashboardcontrol-component)
    *   `ExtensionLanguagePack`
    *   `JavaScript_Library`
    *   `Library`
    *   [Module](https://www.dnnsoftware.com/wiki/modules)
    *   [Provider](https://www.dnnsoftware.com/wiki/providers)
    *   [Skin](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)
    *   `SkinObject`
    *   other custom extension types
*   *version* holds the version of your extension.

Each package represents a DNN extension. You can install multiple extensions using a single DNN manifest by creating a `package` section for each extension inside the `packages` tag.

Packages are installed in the order they appear in the manifest.

Only the information about the _first_ package is displayed during installation. This includes the package name, description, owner, license, and release notes.

### friendlyName and description

```

    <friendlyName>My Sample Module</friendlyName>
    <description>My Sample Module is a demonstration module.</description>

```

The friendlyName and description are displayed during installation and are used in the **Host \> Extensions** page, which lists the extensions that are installed or are available for installation. The friendlyName can contain spaces and up to 250 characters; the description can hold up to 2000 characters.

### iconFile

```

    <iconFile>MyIcon.png</iconFile>

```

Optional. The icon is displayed in the DNN Control Panel's dropdown list and in the Extensions page. The **.png** format is preferred. If not specified, the DNN default icon is used.

### owner

```

    <owner>
        <name>MyCompany or MyName</name>
        <organization>MyCompany Inc.</organization>
        <url>www.example.com</url>
        <email>support@example.com</email>
    </owner>

```

Optional, but encouraged. Information about the owner or creator of the extension.

### license and releaseNotes

```

    <license src="MyLicense.txt" />
    <releaseNotes src="MyReleaseNotes.txt" />

```

Optional, but encouraged. These text files are displayed during the installation. The user is prompted to accept or decline the license. The release notes is displayed during the installation. The actual text can also be embedded within the tag without the src attribute.

### azureCompatible

```

    <azureCompatible>true</azureCompatible>

```

Optional. Default is `false`. Set to `true` if the extension is compatible with Microsoft Azure.

### dependencies

```

    <dependencies>
        <dependency type="coreVersion">08.00.00</dependency>
        ...
    </dependencies>

```

Dependencies can be any of these types (case-insensitive):

*   **coreVersion**. Minimum DNN version required by the extension being installed. Example:

    ```

        <dependency type="coreVersion">08.00.00</dependency>

    ```

*   **managedPackage**. The name and minimum version of a package required by the extension being installed. The required package must already be listed in the core Packages table.

    ```

        <dependency type="managedPackage" version="1.0.0">AnotherPackageRequiredByThisComponent</dependency>

    ```

*   **package**. The name of a package required by the extension being installed. The required package must already be listed in the core Packages table. Example:

    ```

        <dependency type="package">AnotherPackageRequiredByThisComponent</dependency>

    ```

*   **type**. A type in .NET, in a DNN library, or a third-party library. Ensures that the installation can create an object of the specified type. Example:

    ```

        <dependency type="type">System.Security.Principal.GenericPrincipal</dependency>

    ```

    > [!Tip]
    > [Fully qualify](https://docs.microsoft.com/en-us/dotnet/framework/reflection-and-codedom/specifying-fully-qualified-type-names) a type if it is not in the App_Code folder to avoid conflicts with similarly named types from multiple sources.

*   Any custom dependency type included in the Dependency list. DNN can be extended by creating custom dependency types, which inherit from DotNetNuke.Services.Installer.Dependencies.DependencyBase and must be included in the Dependency list (Host \> Lists). Example:

    ```

        <dependency type="SomeCustomDependencyType">ValueNeededBySomeCustomDependencyType</dependency>

    ```
    > [!Note]
    > The custom dependency type must already be installed before it is used in another installation.


## components

```

    <components>
        <component type="..." />
        <component type="..." />
        ...
    </components>

```

Some component types are applicable only to the package type of the same name; generic component types can be used with any package type.

<table>
    <th><strong>Package type</strong></th>
    <th><strong>Specific component type</strong></th>
    <th><strong>Generic component types</strong></th>
    <tr>
        <td>Auth_System</td>
        <td>AuthenticationSystem</td>
        <td rowspan="11"><center><br />Assembly<br />Cleanup<br />Config<br />File<br />ResourceFile<br />Script</center></td>
    </tr>
    <tr>
        <td>Container</td>
        <td>Container</td>
    </tr>
    <tr>
        <td>CoreLanguagePack</td>
        <td>CoreLanguage</td>
    </tr>
    <tr>
        <td>ExtensionLanguagePack</td>
        <td>ExtensionLanguage</td>
    </tr>
    <tr>
        <td>JavaScript_Library</td>
        <td></td>
    </tr>
    <tr>
        <td>Library</td>
        <td></td>
    </tr>
    <tr>
        <td>Module</td>
        <td>Module</td>
    </tr>
    <tr>
        <td>Provider</td>
        <td>Provider<br />URL Provider</td>
    </tr>
    <tr>
        <td>Skin</td>
        <td>Skin</td>
    </tr>
    <tr>
        <td>SkinObject</td>
        <td>SkinObject</td>
    </tr>
</table>

*   [`Assembly`](https://www.dnnsoftware.com/wiki/manifest-assembly-component). Assemblies to be installed in the main \\bin folder of the installation. Assemblies are the compiled code portion of your extension. They can be your own assemblies or third-party assemblies that you ship with your extension.

    ```

        <component type="Assembly">
            <assemblies>
                <assembly>
                    <path / <!-- Path of the assembly to install. Relative to the \bin folder of the DNN installation. -->
                    <name / <!-- Name of the assembly to install. -->
                    <version / <!-- Version of the assembly to install. -->
                </assembly>
                <assembly action="Unregister">
                    <path / <!-- Path of the assembly to remove. Relative to the \bin folder of the DNN installation. -->
                    <name / <!-- Name of the assembly to remove. -->
                    <version / <!-- Version of the assembly to remove. -->
                </assembly>
                ...
            </assemblies>
        </component>

    ```

*   [`AuthenticationSystem`](https://www.dnnsoftware.com/wiki/manifest-authenticationsystem-component). Defines a new Authentication System to be made available within DNN.  Examples include **Facebook**, **Google**, **Twitter**, and **Microsoft Accounts**. By default, DNN authenticates using its own database.

    ```

        <component type="AuthenticationSystem">
            <authenticationService>
                <type>Facebook</type>
                <settingsControlSrc />
                <loginControlSrc />
                <logoffControlSrc />
            </authenticationService>
            <authenticationService />
            ...
        </component>

    ```

*   [`Cleanup`](https://www.dnnsoftware.com/wiki/cleanup-component). List of files that must be deleted during installation or upgrade of the package.

    You can list the files individually in the manifest.

    ```

        <component type="Cleanup" version="07.40.00">
            <files>
                <file>
                    <path>bin</path>
                    <name>MyFile.dll</name>
                </file>
                <file />
                ...
            </files>
        </component>

    ```

    You can also list the files with their paths in a text file instead.

    ```

        <component type="Cleanup" version="07.40.00" fileName="ListOfFilesToDelete.txt" />

    ```

    Starting with Dnn 9.5.0, you can also use a globbing patterns as in this example.
    
    ```
        <component type="Cleanup" version="07.40.00" glob="DesktopModules/MyModule/scripts/*;DesktopModule/MyModule/images/*.gif;DesktopModules/MyModule/**/*.txt" />
    ```

    Notes:
    * You can specify more than one globbing pattern on the same line by separating each pattern with `;`
    * More information on supported globbing patterns can be found at the [Microsoft.Extensions.FileSystemGlobbing documentation](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.filesystemglobbing.matcher?view=dotnet-plat-ext-3.1#remarks)
    * Globbing patterns can only be used to match files, not directories (if you need to delete a directory, first it needs to be empty, then you need to use one of the above methods to delete the actual directory).
    * All methods take paths relative to the application root folder, for that reason `..` is intentionally not supported with globbing patterns in this component.

    See also:

    *   Component type `Config` to update configuration files during uninstall.
    *   Component type `Script` for data provider scripts that must be uninstalled.

*   [`Config`](https://www.dnnsoftware.com/wiki/manifest-config-component). Changes to do on the specified config file.

    ```

        <component type="Config">
            <config>
                <configFile>web.config</configFile <!-- Name of config file, including its path relative to the root of the DNN installation. -->
                <install>
                    <configuration>
                        <nodes>
                            <node path="/configuration/system.webServer/handlers" action="update" key="path" collision="overwrite">
                                ...
                            </node>
                            <node />
                            ...
                        </nodes>
                    </configuration>
                </install>
                <uninstall>
                    <configuration>
                        <nodes />
                    </configuration>
                </uninstall>
            </config>
            <config />
            ...
        </component>

    ```

    For information on `node` attributes, see [Manifest: XML Merge](https://www.dnnsoftware.com/wiki/manifest-xml-merge).

*   [`Container`](https://www.dnnsoftware.com/wiki/manifest-container-component). Containers to be installed.

    ```

        <component type="Container">
            <containerFiles>
                <basePath / <!-- Target base folder for the component installation. Relative to the root of the DNN installation. -->
                <containerName />
                <containerFile>
                    <path / <!-- Target file folder. Relative to basePath. -->
                    <name />
                </containerFile>
                <containerFile />
                ...
            </containerFiles>
        </component>

    ```

*   [`File`](https://www.dnnsoftware.com/wiki/manifest-file-component). Files to be installed. By default, only files with allowed file extensions are installed; however, the host user can bypass this security check during installation. To view or modify the list of file extensions, go to your DNN installation and choose **Host \> Host Settings \> Other Settings \> Allowable File Extensions**.

    ```

        <component type="File">
            <files>
                <basePath / <!-- Target base folder for the component installation. Relative to the root of the DNN installation. -->
                <file>
                    <path / <!-- Target file folder. Relative to basePath. Also assumed to be the source file folder in the zip file, if sourceFileName is not defined. -->
                    <name />
                    <sourceFileName / <!-- The path and name of a file inside the zip file. -->
                </file>
                <file />
                ...
            </files>
        </component>

    ```

    Example: To copy img/MyAwesomeImageFile.jpg from the zip file to desktopmodules/mymodule/images/MyFile.jpg,

    ```

        <basePath>desktopmodules/mymodule</basePath>
        <file>
            <path>images</path>
            <name>MyFile.jpg</name>
            <sourceFileName>img/MyAwesomeImageFile.jpg</sourceFileName>
        </file>

    ```

*   [`CoreLanguage`](https://www.dnnsoftware.com/wiki/manifest-corelanguage-component). Language pack files required to localize the core DNN Platform for a specific culture. A core language pack can be installed during the DNN Platform installation or anytime after.

    ```

        <component type="CoreLanguage">
            <languageFiles>
                <code />
                <displayName />
                <fallback / <!-- Code for the alternative language. Used if a resource is not found in the current language pack. -->
                <languageFile>
                    <path / <!-- Target file folder. Relative to the root of the DNN installation. -->
                    <name />
                </languageFile>
                <languageFile />
                ...
            </languageFiles>
        </component>

    ```

    For the list of supported language codes, see the .NET [CultureInfo](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo) class.

*   [`ExtensionLanguage`](https://www.dnnsoftware.com/wiki/manifest-extensionlanguage-component). Language pack files required to localize a DNN extension for a specific culture.

    ```

        <component type="ExtensionLanguage">
            <languageFiles>
                <code />
                <package / <!-- Name of another package that contains the extension that this language pack is intended for. -->
                <basePath / <!-- Target base folder for the component installation. Relative to the root of the DNN installation. -->
                <languageFile>
                    <path / <!-- Target file folder. Relative to basePath. -->
                    <name />
                </languageFile>
                <languageFile />
                ...
            </languageFiles>
        </component>

    ```

    For the list of supported language codes, see the .NET [CultureInfo](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo) class.

*   [`Module`](https://www.dnnsoftware.com/wiki/module-component). Only one component with `type="Module"` is allowed within a `package` section. To install a set of modules as a unit, create one `package` section per module in the same manifest.

    ```

        <component type="Module">
            <desktopModule>
                <moduleName />
                <foldername />
                <businessControllerClass />
                <codeSubdirectory />
                <isAdmin />
                <isPremium />
                <supportedFeatures<!-- Requires a value for businessControllerClass. -->
                    <supportedFeature type="Portable" /<!-- The module has import/export capabilities using the IPortable interface. -->
                    <supportedFeature type="Searchable" /<!-- The module can be indexed or searched using the ISearchable interface. -->
                    <supportedFeature type="Upgradeable" /<!-- The module can be upgraded using the IUpgradeable interface. -->
                    ...
                </supportedFeatures>
                <moduleDefinition>
                    <friendlyName />
                    <defaultCacheTime />
                    <moduleControls>
                        <moduleControl>
                            <controlKey />
                            <controlSrc />
                            <supportsPartialRendering />
                            <controlTitle />
                            <controlType />
                            <iconFile />
                            <helpUrl />
                        </moduleControl>
                        <moduleControl />
                        ...
                    </moduleControls>
                    <permissions>
                        <!-- In <permission>,
                            "code" is the code for the module,
                            "key" is the code for the permission, and
                            "name" is the user-friendly name for the permission.
                        -->
                        <permission code="..." key="..." name="..." />
                        <permission code="..." key="..." name="..." />
                        ...
                    </permissions>
                </moduleDefinition>
            </desktopModule>
            <eventMessage>
                <processorType />
                <processorCommand />
                <attributes>
                    <node>value</node>
                </attributes>
            </eventMessage>
        </component>

    ```

*   [`Provider`](https://www.dnnsoftware.com/wiki/manifest-provider-component). Extends the list of allowed file extensions. These additional file extensions apply only to the current installation and are not added to the global list of file extensions found in **Host \> Host Settings \> Other Settings \> Allowable File Extensions**. The following file extensions can be allowed: .ashx, .aspx, .ascx, .vb, .cs, .resx, .css, .js, .resources, .config, .xml, .htc, .html, .htm, .text, .vbproj, .csproj, and .sln.

    ```

        <component type="Provider" />

    ```

*   [`ResourceFile`](https://www.dnnsoftware.com/wiki/manifest-resourcefile-component). Zip files to be expanded during installation. Can be used instead of `component type="File"` to simplify the manifest for packages that contain many files.

    ```

        <component type="ResourceFile">
            <resourceFiles>
                <basePath /<!-- Target folder where the contents of the zip file will be installed. Relative to the root of the DNN installation. -->
                <resourceFile>
                    <name /<!-- Name of zip file. -->
                </resourceFile>
                <resourceFile />
                ...
            </resourceFiles>
        </component>

    ```

*   [`Script`](https://www.dnnsoftware.com/wiki/script-component). Database scripts that the extension needs. The following scripts are handled differently:

    *   `install.<dataprovidertype>` (e.g., `install.SqlDataProvider`) is executed _before_ all other scripts, if the package is being installed for the first time.
    *   `upgrade.<dataprovidertype>` (e.g., `upgrade.SqlDataProvider`) is executed _after_ all regular scripts.

    ```

        <component type="Script">
            <scripts>
                <basePath /<!-- Target base folder for the component installation. Relative to the root of the DNN installation. -->
                <script type="Install" >
                    <path /<!-- Target file folder. Relative to basePath. -->
                    <name /<!-- Must be named "<scriptversion>.<dataprovider>". Example: 01.00.00.SqlDataProvider -->
                    <version /<!-- Version of script file to be installed. -->
                </script>
                <script type="UnInstall" >
                    <path /<!-- Location of script file. Relative to basePath. -->
                    <name /<!-- Must be named "uninstall.<dataprovidertype>". Example: uninstall.SqlDataProvider -->
                    <version /<!-- Version of script file to be removed. -->
                </script>
                ...
            </scripts>
        </component>

    ```

*   [`Skin`](https://www.dnnsoftware.com/wiki/manifest-skin-component). All files related to the theme. The installer needs to parse the main theme files at installation time to replace relative folder names; therefore, every ASCX, HTML, or CSS file must be declared as a `skinFile`. Other files (i.e., images and scripts) can be packaged using component type `ResourceFile` to simplify the complexity of the theme manifest.

    ```

        <component type="Skin">
            <skinFiles>
                <basePath /<!-- Target base folder for the component installation. Relative to the root of the DNN installation. -->
                <skinName />
                <skinFile>
                    <path /<!-- Target file folder. Relative to basePath. -->
                    <name />
                </skinFile>
                <skinFile />
                ...
            </skinFiles>
        </component>

    ```

*   [`SkinObject`](https://www.dnnsoftware.com/wiki/manifest-skinobject-component). Custom theme objects.

    ```

        <component type="SkinObject">
            <moduleControl>
                <controlKey /<!-- Token of the skin object within square brackets []; e.g., [COPYRIGHT] -->
                <controlSrc /<!-- Target file folder for the theme object's ASCX file. -->
                <supportsPartialRendering /<!-- "true" if the theme object supports partial rendering through an MS AJAX update panel wrapper. Default: "false" -->
            </moduleControl>
        </component>

    ```

*   [`URLProvider`](https://www.dnnsoftware.com/wiki/manifest-url-provider). Custom URL provider to be used with the **Advanced URL Management System (AUM)**.

    ```

        <component type="URLProvider">
            <urlProvider>
                <name />
                <type />
                <settingsControlSrc />
                <redirectAllUrls />
                <replaceAllUrls />
                <rewriteAllUrls />
                <desktopModule />
            </urlProvider>
        </component>

    ```
