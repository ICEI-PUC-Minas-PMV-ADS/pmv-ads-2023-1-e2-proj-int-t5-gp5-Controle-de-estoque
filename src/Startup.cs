app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    
    endpoints.MapControllerRoute(
        name: "login",
        pattern: "login",
        defaults: new { controller = "Account", action = "Login" });

    endpoints.MapControllerRoute(
        name: "register",
        pattern: "register",
        defaults: new { controller = "Account", action = "Register" });
});
