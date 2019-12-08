---
uid: mvc-module-unittest
locale: en
title: Create a Unit Test for an MVC module
dnnversion: 09.02.00
related-topics: mvc-module-project-overview,mvc-module-mvccontroller,mvc-module-mvcviews,unsupported-mvc-features
links: ["[Microsoft MSDN: Unit Test Basics](https://docs.microsoft.com/en-us/visualstudio/test/unit-test-basics)","[Microsoft Visual Studio: Run tests with your builds for continuous integration](https://www.visualstudio.com/en-gb/docs/test/continuous-testing/test-build)","[Moq](https://www.nuget.org/packages/Moq/)"]
---

# Create a Unit Test for an MVC module

## Overview

Because MVC controllers are the central business logic of an MVC module, it is a best practice to create automated unit tests to ensure they behave as intended. This example illustrates how to create a unit test for your module's MVC controller.

> [!Note]
> This unit test procedure is applicable only to modules created with the DNN MVC module template.

## Prerequisites

*   A module created with the DNN MVC module template in Visual Studio as a Project with Templates.
*   [Moq](https://www.nuget.org/packages/Moq/), a simulation framework for C#/.NET.

## Steps

1.  Add a new unit test project to the MVC module solution.
    1.  In Visual Studio's Solution Explorer, right-click on your MVC module solution and select Add \> New Project.



        ![Add New Project](/images/scr-mvc-unittest-addproject.png)



    2.  In the Add New Project dialog, select Unit Test Project, enter a name, and select the local folder to store it in.



        ![Create Unit Test project](/images/scr-mvc-unittest-create.png)



2.  Add the necessary MVC and DNN assembly references.

    For each assembly to be added to the new unit test project, right-click on the project's References node and add an assembly reference.



    ![Project Reference](/images/scr-mvc-unittest-projref.png)



    Add references to the following assemblies, as well as others that your module specifically needs:

    *   DotNetNuke
    *   DotNetNuke.Web.Mvc
    *   System.Web.Mvc

3.  (Optional) Use Moq to simulate a data store.

    Moq is a simulation framework for C#/.NET, typically used in unit testing to quickly create dependency objects that mimic the actual objects. This project uses Moq to simulate an ItemManager object in order to run tests without requiring a database.

    Note: This step is not required for the example test, but it is needed in most real-world test cases.

    1.  In Visual Studio's Solution Explorer, right-click on your unit test project.
    2.  Choose Manage Nuget Packages.
    3.  Search for Moq and install.



        ![Moq Nuget Installation](/images/scr-mvc-unittest-moqnuget.png)




    This example creates a MockStores class for use with Moq to simulate a database and its behavior.

    Create a folder called Mocks and create a MockStores.cs file inside the folder. Enter the following code in MockStores.cs:

    ```

        using System.Collections.Generic;
        using System.Linq;
        using Dnn.Modules.CompanyName.MyMvcModule.Components;
        using Dnn.Modules.CompanyName.MyMvcModule.Models;
        using Moq;

        namespace MyMvcModuleTests.Mocks
        {
            class MockStores
            {
                public static Mock<IItemManager> MockItemManager()
                {
                    var allItems = new List<Item>();
                    var mock = new Mock<IItemManager>();

                    // void CreateItem(Item t);
                    mock.Setup(x => x.CreateItem(It.IsAny<Item>()))
                        .Callback((Item i) =>
                        {
                            allItems.Add(i);
                        });

                    // void DeleteItem(int itemId, int moduleId);
                    mock.Setup(x => x.DeleteItem(It.IsAny<int>(), It.IsAny<int>()))
                        .Callback((int id, int mid) =>
                        {
                            var remItem = allItems.FirstOrDefault(i => i.ItemId == id && i.ModuleId == mid);
                            allItems.Remove(remItem);
                        });

                    // void DeleteItem(Item t);
                    mock.Setup(x => x.DeleteItem(It.IsAny<Item>()))
                        .Callback((Item di) =>
                        {
                            var remItem = allItems.FirstOrDefault(i => i.ItemId == di.ItemId);
                            allItems.Remove(remItem);
                        });

                    // IEnumerable<Item> GetItems(int moduleId);
                    mock.Setup(x => x.GetItems(It.IsAny<int>()))
                        .Returns((int mid) => allItems.Where(x => x.ModuleId == mid));

                    // Item GetItem(int itemId, int moduleId);
                    mock.Setup(x => x.GetItem(It.IsAny<int>(), It.IsAny<int>()))
                        .Returns((int id, int mid) => allItems.FirstOrDefault(i => i.ItemId == id && i.ModuleId == mid));

                    // void UpdateItem(Item t);
                    mock.Setup(x => x.UpdateItem(It.IsAny<Item>()))
                        .Callback((Item i) =>
                        {
                            allItems.Add(i);
                        });

                    return mock;
                }
            }
        }

    ```

    The static MockItemManager() method in the MockStores class simulates all methods of an IItemManager implementation. Therefore, MockStores can be used in the controller as the IItemManager implementation.

    The allItems variable is a generic list of Item objects and serves as the data store.

4.  Create the unit test.

    Tip: Unit test method names should be more descriptive than typical methods. Ideally, the test method name includes the name of the method being tested, the test being performed, and the expected result. Example: `Edit_CreateNewItem_ModuleIdAssignedinModel` could be the name of a test method that verifies if an Edit() method creates a new item (if the item does not yet exist) by checking if the moduleID is assigned in the view's model.

    This example creates a unit test for the ItemController class.

    You can rename the sample unit test file UnitTest1.cs (included as a default when the new unit test project was created) to ItemControllerTests.cs or create a new file. Then enter the following code in ItemControllerTests.cs:

    ```

    	using System.Web.Mvc;
    	using Dnn.Modules.CompanyName.MyMvcModule.Controllers;
    	using Dnn.Modules.CompanyName.MyMvcModule.Models;
    	using Microsoft.VisualStudio.TestTools.UnitTesting;
    	using MyMvcModuleTests.Mocks;

    	namespace MyMvcModuleTests
    	{
    		[TestClass]
    		public class ItemControllerTests
    		{
    			[TestMethod]
    			public void Edit_CreateNewItem_ModuleIdAssignedinModel()
    			{
    				// 1 - Arrange
    				int moduleId = 2;
    				var mockData = MockStores.MockItemManager();
    				var modTwoItemCntrl = new ItemController(mockData.Object, moduleId); // Create a controller for the module with moduleId=2.

    				// 2 - Act
    				var actionResult = (ViewResult)modTwoItemCntrl.Edit(); // Call the edit view with no item Id (Add New).

    				// 3 - Assert
    				var itemModel = (Item)actionResult.Model;
    				Assert.IsTrue(itemModel != null && itemModel.ModuleId == moduleId);
    			}
    		}
    	}

    ```

    This sample unit test uses the Arrange Act Assert pattern of unit testing:

    *   Arrange: A new instance of ItemController is created with a new MockStores.MockItemManager instance and the moduleId. (The next step retrofits the ItemController constructor to work with this unit test.
    *   Act: The Edit() method of the control is called without any parameters, and the result is saved.
    *   Assert: The test verifies that the moduleId is set in the resulting View module before the add/edit-item view is rendered.

    If your controller has more complex business logic, you can automate the validation of the unit test.

5.  Retrofit the ItemController.Edit() method to work with unit tests.

    In code that was generated using the MVC module templates, the ItemController has no dependency-injection capability for the data layer. In addition, some basic DNN environment objects, such as PortalSettings and ModuleContext are not available when running unit tests. Retrofitting the ItemController.Edit() method fixes these limitations.

    This example adds a constructor and class variable to the ItemController to inject the IItemManager implementation/simulator and moduleId.

    ```

        public ActionResult Edit(int itemId = -1)
        {
            // Ignore registration errors for unit tests.
            try { DotNetNuke.Framework.JavaScriptLibraries.JavaScript.RequestRegistration(CommonJs.DnnPlugins); }
            catch { }

            if (PortalSettings != null)
            {
                var userlist = UserController.GetUsers(PortalSettings.PortalId);
                var users = from user in userlist.Cast<UserInfo>().ToList()
                select new SelectListItem { Text = user.DisplayName, Value = user.UserID.ToString() };

                ViewBag.Users = users;
            }

            if (ModuleContext != null)
            {
                _moduleId = ModuleContext.ModuleId;
            }

            var item = (itemId == -1)
                ? new Item { ModuleId = _moduleId }
                : ItemManager.Instance.GetItem(itemId, _moduleId);

            return View(item);
        }

    ```

    Some lines in the default ItemController are not applicable to this sample unit test, which uses an ItemController simulation.

    To ignore those lines when running the unit test, the retrofitted ItemController.Edit() method checks PortalSettings and ModuleContext, which get their values from the module's runtime engine. During the unit test, the runtime engine is bypassed by the ItemController simulation; therefore, these variables are set to `null` when the unit test is running.

    The _moduleId variable is passed to the constructor as the itemId parameter by the sample unit test and the ItemManager.Instance will be our mock instance because our unit test overrode the implementation in the constructor.

6.  Run the unit test.

    You can run a unit test in Visual Studio:

    *   Test \> Debug
    *   Test \> Run

    The Test Explorer window gives you a quick view of all tests, the test results, and the commands to run them.



    ![Test Explorer](/images/scr-mvc-unittest-testexplorer.png)



    For more advanced users, unit tests can be scheduled to run automatically as part of your build process.
