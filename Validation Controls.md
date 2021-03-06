# Validation Controls      <br/>

Validation is important part of any web application. User's input must always be validated before sending across different layers of the application.

#### Validation controls are used to:<br/>
- To validate user input data.
- Data format, data type and data range is used for validation.

### There are six types of validation controls in ASP.NET 
1) RequiredFieldValidator Control
2) CompareValidator Control
3) RangeValidator Control
4) RegularExpressionValidator Control
5) CustomValidator Control


#### Important points for validation controls<br/>
ControlToValidate property is mandatory to all validate controls.<br/>
One validation control will validate only one input control but multiple validate control can be assigned to a input control.


### 1) RequiredFieldValidator control

The RequiredFieldValidator control is simple validation control, which checks to see if the data is entered for the input control.<br/>
#### <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator

### 2) CompareValidator Control
 
The CompareValidator control allows you to make comparison to compare data entered in an input control with a constant value or a value in a different control.<br/>
#### <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator"></asp:CompareValidator>

### 3) RangeValidator Control
 
The RangeValidator control, which checks to see if a control value is within a valid range or not.<br/>
#### <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator"></asp:RangeValidator>

### 4) RegularExpressionValidator Control
 
A regular expression is a  pattern matching  that can be used to identify simple  sequence.<br/>
Using RegularExpressionValidator server control, you can check a user's input based on a pattern that you define using a regular expression.<br/>
 expression can be phone number, email address.<br/>
#### <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
 
 ### 5) CustomValidator control
 CustomValidator control provides the customize validation code to perform both client-side and server-side validation. <br/>
 For example, you can create a validation control that checks whether the value entered into a text box is 8 or more characters long.<br/> 
#### <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>

# User Control

- User controls are containers into which you can put markup and Web server controls.
- UserControl file has .ascx extension.
- An ASP.NET Web user control is similar to a complete ASP.NET Web page (.aspx file), with both a user interface page and code. 
- You create the user control in much the same way you create an ASP.NET page
- The user control does not have html, body, or form elements in it. These elements must be in the hosting page.
- You can use the same HTML elements (except the html, body, or form elements) and Web controls on a user control.
- The code in User Control can be reused .
 
