# ASP.NET Page Life Cycle

## Page life cycle phases 
- Initialization
- Instantiation of the controls on the page
- Restoration and maintenance of the state
- Execution of the event handler codes
- Page rendering

## Page life cycle Events

|                 Page Life Cycle Events                        |                                                                                                     |                                         
|---------------------------------------------------------------|---------------------------------------------------------------------------------------------------- |
| PreInit                                                       | This event happens just before page initialisation event starts .                                   |
|                                                               |  Is postback and Is cross page postback properties are set at this stage.                           |
|                                                               |  this event allows us to set the master page and theme of webapplication dynamically.               |
| Init                                                          | page init, event occurs after the init event of all the individual controls on the web form .       | 
|                                                               |  Use this event to read or initialize control properties. the server controls are loaded            |
|                                                               |  and initialized from the web forms viewstate.                                                      |
| InitComplete                                                  | This event occurs immediately after page initialization.                                            |
|                                                               | Until this event occurs the viewstate values are not yet loaded,                                    |
|                                                               | we can use this event to changes to the view state .                                                |                                                                                         
| PreLoad                                                       | This event occurs just before the page load event.                                                  |                                                                                                                                           
| Load                                                          | page load event occurs before the load event of all individual controls on that web form            |                                                                                                                                          
| Control Events                                                | After the page load event the control events like on button click, dropdown list events are raised  |                                                                                                                                         
| Load Complete                                                 | This event occurs after the control events are handled.                                             |                                                                                                                                        
| PreRender                                                     | This event occurs before the rendering stage of the page.                                           |                                                                                                                                         
| PreRenderComplete                                             | This event occurs immediately after the prerender event.                                            |                                                                                                                                           
| Unload                                                        | This event occurs for each control and then for the page.                                           |
|                                                               |  At this stage the page is unloaded from memory.                                                    |                                

###### public partial class PageLiftCycle: System.Web.UI.Page 
###### {  
    protected void Page_PreInit(object sender, EventArgs e) 
    {  Response.Write("Page_PreInit" +"<br/>");
         
    }  
    protected void Page_Init(object sender, EventArgs e) 
    {  Response.Write("Page_Init " +"<br/>");
       
    }  
    protected void Page_InitComplete(object sender, EventArgs e) 
    {  
        Response.Write("Page_InitComplete" +"<br/>");
    }  
    protected override void OnPreLoad(EventArgs e)
    {  
        Response.Write("OnPreLoad" +"<br/>");
    }  
    protected void Page_Load(object sender, EventArgs e) 
    {  
        Response.Write("Page_Load" +"<br/>");
    }  
    protected void btnSubmit_Click(object sender, EventArgs e) 
    {  
        Response.Write("btnSubmit_Click" +"<br/>");
    }  
    protected void Page_LoadComplete(object sender, EventArgs e)
    {  
          Response.Write("Page_LoadComplete" +"<br/>");
    }  
    protected override void OnPreRender(EventArgs e) 
    {  
       Response.Write("OnPreRender" +"<br/>");
    }  
    protected override void OnSaveStateComplete(EventArgs e) 
    {  
        Response.Write("OnSaveStateComplete" +"<br/>");
    }  
    protected void Page_UnLoad(object sender, EventArgs e) 
    {  
        Response.Write("Page_UnLoad" +"<br/>");
        
    }  
}  
 
 
 
 
 
 
 
 
