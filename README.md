

# BunifuDatePickerDemo

[![N|Solid](https://bunifuframework.com/wp-content/uploads/2017/06/Bunifu-framework-logo-web.png)](https://bunifuframework.com/)

## BunifuDatePicker
![Example](https://github.com/k33ptoo/BunifuDatePickerDemo/blob/master/res/imgs/sample.gif)

This demo shows how to make use of BunifuDatePicker to it's maximum, it has custom properties including

  - **BorderRadius** -Gets or Sets the border radius of the datepicker
  - **Color** - Gets or Sets the color of the datepicker control
  - **DateBorderThickeness** - Gets or Sets the Type of border thickness of the control 
  - **DisplayWeekNumber** - Gets or Sets the Week Display Property to true or false
  - **FillDatePicker** - Gets or Sets the fill type of the datepicker to true of false
  - **Icon** - Gets or Sets the icon of the control
  - **IconColor** - Gets or Sets the color of the Icon
  - **IconLocation** - Gets or Sets the location of the icon to Right or Left.

Advantages of BunifuDatePicker is you can achieve your desired look with a few property changes and also give your project a modern look.
**Screenshot**

![Example](https://github.com/k33ptoo/BunifuDatePickerDemo/blob/master/res/imgs/img1.png)

![Example](https://github.com/k33ptoo/BunifuDatePickerDemo/blob/master/res/imgs/img2.png)

## Using DatePicker Value
BunifuDatePicker has **Value** property where you can Get or Set its value, say if you want the displayed value of the datepicker to be yesterday you can set it like
```csharp
DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(1));
            bunifuDatePicker1.Value = result;
```

Information about DatePicker Value Property is found [here](https://msdn.microsoft.com/en-us/library/system.windows.forms.datetimepicker.value%28v=vs.110%29.aspx)

**Libraries**

MySql.Data.dll

Bunifu.Core.dll

Bunifu.UI.WinForms.BunifuDatePicker.dll

Note : Make sure you add these libraries before testing this app  

**Others**

Buy or try [Bunifu Framework](https://bunifuframework.com/) Today


