using System;
using Microsoft.JSInterop;

namespace BlazorWeb.Helper;

public static class IJSRuntimeExtensions
{
    public  static async Task ToastrSuccess(this IJSRuntime jsRuntime, string message, string title = "Success")
    {
        await jsRuntime.InvokeVoidAsync("showToastr", "success", message, title);
    }

     public  static async Task ToastrDanger(this IJSRuntime jsRuntime, string message, string title = "Danger")
    {
        await jsRuntime.InvokeVoidAsync("showToastr", "error", message, title);
    }

    public static async Task SweetalertSuccess(this IJSRuntime jsRuntime, string title, string message)
    {
        await jsRuntime.InvokeVoidAsync("ShowSwal", title, message, "success");
    }

    public static async Task SweetalertError(this IJSRuntime jsRuntime, string title, string message)
    {
        await jsRuntime.InvokeVoidAsync("ShowSwal", title, message, "error");
    }
}