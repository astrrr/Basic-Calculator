#pragma checksum "D:\basic calculator\BasicCalculator\BasicCalculator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbf7f35a1281c20f64e8891787aadbd2c1dc005c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\basic calculator\BasicCalculator\BasicCalculator\Views\_ViewImports.cshtml"
using BasicCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\basic calculator\BasicCalculator\BasicCalculator\Views\_ViewImports.cshtml"
using BasicCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf7f35a1281c20f64e8891787aadbd2c1dc005c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d349eec2d6155d98be71ac81624f0aa4ada8b3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\basic calculator\BasicCalculator\BasicCalculator\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <div class=""text-center"">
    <input class=""form-control"" id=""result"" name=""result"" type=""text"" disabled value=""0"">
    <table>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;<input class=""buttonSize"" id=""ButtonAC"" type=""button"" value=""AC"" onclick=""ac()""></td>
            <td>&nbsp;<input class=""buttonSize"" id=""ButtonDel"" type=""button"" value=""Del"" onclick=""del()""></td>
        </tr>
        <tr>
            <td>&nbsp;<input class=""buttonSize"" id=""Button7"" type=""button"" value=""7"" onclick=""pressNum('7')""></td>
            <td>&nbsp;<input class=""buttonSize"" id=""Button8"" type=""button"" value=""8"" onclick=""pressNum('8')""></td>
            <td>&nbsp;<input class=""buttonSize"" id=""Button9"" type=""button"" value=""9"" onclick=""pressNum('9')""></td>
            <td>&nbsp;<input class=""buttonSize"" id=""ButtonDiv"" type=""button"" value=""÷"" onclick=""divide()""></td>
        </tr>
        <tr>
            <td>&nbsp;<input class=""buttonSize"" id=""Button4"" type=""button"" val");
            WriteLiteral(@"ue=""4"" onclick=""pressNum('4')""></td>
            <td>&nbsp;<input class=""buttonSize"" id=""Button5"" type=""button"" value=""5"" onclick=""pressNum('5')""></td>
            <td>&nbsp;<input class=""buttonSize"" id=""Button6"" type=""button"" value=""6"" onclick=""pressNum('6')""></td>
            <td>&nbsp;<input class=""buttonSize"" id=""ButtonMul"" type=""button"" value=""×"" onclick=""mul()""></td>
        </tr>
        <tr>
            <td>&nbsp;<input class=""buttonSize"" id=""Button1"" type=""button"" value=""1"" onclick=""pressNum('1')""></td>
            <td>&nbsp;<input class=""buttonSize"" id=""Button2"" type=""button"" value=""2"" onclick=""pressNum('2')""></td>
            <td>&nbsp;<input class=""buttonSize"" id=""Button3"" type=""button"" value=""3"" onclick=""pressNum('3')"" ></td>
            <td>&nbsp;<input class=""buttonSize"" id=""ButtonSub"" type=""button"" value=""-"" onclick=""sub()""></td>
        </tr>
        <tr>
            <td>&nbsp;<input class=""buttonSize"" id=""Button."" type=""button"" value=""."" onclick=""pressNum('.')""></td>
           ");
            WriteLiteral(@" <td>&nbsp;<input class=""buttonSize"" id=""Button0"" type=""button"" value=""0"" onclick=""pressNum('0')""></td>
            <td>&nbsp;<input class=""buttonSize"" id=""Button="" type=""button"" value=""="" onclick=""equ()""></td>
            <td>&nbsp;<input class=""buttonSize"" id=""ButtonAdd"" type=""button"" value=""+"" onclick=""add()""></td>
              
        </tr>
    </table>
</div>




<script>
    var display = document.getElementById('result');

    var xmlhttp = new XMLHttpRequest();
    

    function pressNum(num) {
        if (display.value[0] == '0') {
            display.value = display.value.slice(1, -1);
            display.value = display.value.concat(num);
            console.log(""have zero"");
        }
        else {
            display.value = display.value.concat(num);
        }
    }

    
    function add() {
        
        display.value = display.value.concat('+');
    }

    function sub() {
        
        display.value = display.value.concat('-');
    }

    func");
            WriteLiteral(@"tion divide() {
       
        display.value = display.value.concat('÷');
    }

    function mul() {
       
        display.value = display.value.concat('×');
    }

    function dot() {
        
        display.value = display.value.concat('.');
    }

    function ac() {
        
        display.value = '0';
    }

    function del() {
        let txt = display.value;
        if (!(display.value[0] == '0')) {

        display.value = display.value.slice(0, -1);
        }
        if (txt.length == 1 && txt != '0') {
            display.value = '0';
        }
    }

    function equ() {
        
        let txt = display.value;
        xmlhttp.open(""GET"", ""https://localhost:44316/Home/Operate?rawResult=""+ txt);
            xmlhttp.onreadystatechange = function () {
                if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                    display.value = xmlhttp.responseText;
                }
            }
        xmlhttp.send();
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
