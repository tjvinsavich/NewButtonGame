#pragma checksum "C:\Users\tjvin\Desktop\repos\NewButtonGame\NewButtonGame\Views\Button\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad521f561bb9f857f3c08ca99682256b002f7d0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Button_Index), @"mvc.1.0.view", @"/Views/Button/Index.cshtml")]
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
#line 1 "C:\Users\tjvin\Desktop\repos\NewButtonGame\NewButtonGame\Views\_ViewImports.cshtml"
using NewButtonGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tjvin\Desktop\repos\NewButtonGame\NewButtonGame\Views\Button\Index.cshtml"
using NewButtonGame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad521f561bb9f857f3c08ca99682256b002f7d0e", @"/Views/Button/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50f30b869cedf8b0357e7c64f371c3a202e43148", @"/Views/_ViewImports.cshtml")]
    public class Views_Button_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script>
    function one() {
        location.href = ""https://localhost:5001/Button/One"";
    }

    function two() {
        location.href = ""https://localhost:5001/Button/Two"";
    }

    function three() {
        location.href = ""https://localhost:5001/Button/Three"";
    }

    $(document).ready(function () {        $("".button"").hover(function () {            $(this).css('background-color', 'red');        }, function () {            $(this).css('background', 'none');        });    });


</script>

<h1></h1>

<h2>Score: ");
#nullable restore
#line 32 "C:\Users\tjvin\Desktop\repos\NewButtonGame\NewButtonGame\Views\Button\Index.cshtml"
      Write(Button.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h2>High Score: ");
#nullable restore
#line 34 "C:\Users\tjvin\Desktop\repos\NewButtonGame\NewButtonGame\Views\Button\Index.cshtml"
           Write(Button.HighScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
            WriteLiteral("\r\n<p class=\"thank\">The bomb was ");
#nullable restore
#line 40 "C:\Users\tjvin\Desktop\repos\NewButtonGame\NewButtonGame\Views\Button\Index.cshtml"
                         Write(Button.BadButton);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"!</p>
<div class=""button one"">
    <p>One</p>
</div>
<div class=""button two"">
    <p>Two</p>
</div>
<div class=""button three"">
    <p>Three</p>
</div>

<div id=""stars""></div>
<div id=""stars2""></div>
<div id=""stars3""></div>

<script>
    let buttonOne = document.querySelector("".one"");
    let buttonTextOne = document.querySelector("".one p"");

    let buttonTwo = document.querySelector("".two"");
    let buttonTextTwo = document.querySelector("".two p"");

    let buttonThree = document.querySelector("".three"");
    let buttonTextThree = document.querySelector("".three p"");


    let thankText = document.querySelector("".thank"");

    let timeLine = new TimelineMax({
        paused: false
    });

    buttonOne.addEventListener(""click"", () => {
        if (");
#nullable restore
#line 73 "C:\Users\tjvin\Desktop\repos\NewButtonGame\NewButtonGame\Views\Button\Index.cshtml"
       Write(Button.BadButton);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" == 1) {
            timeLine
                .to("".thank"", 1, {
                    opacity: 1,
                    delay: 0.3
                })
                .to(buttonTextOne, 0.6, {
                    opacity: 0
                })
                .to(buttonOne, 0.8, {
                    height: 0.2,
                    opacity: 0.5,
                    boxShadow: ""0px 0px 35px 7px #cd28fa"",
                    delay: 0.25
                })
                .to(buttonOne, 0.1, {
                    opacity: 0.5,
                    background: ""#26ff92""
                })
                .to(buttonOne, 0, {
                    width: 1,
                    delay: 0.2
                })
                // .to(button, 1, {
                //     boxShadow: ""0px 0px 100px 55px #fa2856"",
                //     height: 100,
                //     delay: 0.3
                // })
                .to(buttonOne, 0.1, {
                    boxShadow: ""0px 0px 100px 55px #fa2856"",
");
            WriteLiteral(@"                    y: 90,
                    height: 100,
                    delay: 0.23
                })
                .to(buttonOne, 0.3, {
                    height: 1000,
                    y: -1500,
                    boxShadow: ""0px 0px 85px 17px #fa2856"",
                    delay: 0.2
                });

            setTimeout(function () { one(); }, 5000);
        }
        else {
            setTimeout(function () { one(); }, 500);
        }

    });

    buttonTwo.addEventListener(""click"", () => {
        if (");
#nullable restore
#line 123 "C:\Users\tjvin\Desktop\repos\NewButtonGame\NewButtonGame\Views\Button\Index.cshtml"
       Write(Button.BadButton);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" == 2) {
            timeLine
                .to("".thank"", 1, {
                    opacity: 1,
                    delay: 0.3
                })
                .to(buttonTextTwo, 0.6, {
                    opacity: 0
                })
                .to(buttonTwo, 0.8, {
                    height: 0.2,
                    opacity: 0.5,
                    boxShadow: ""0px 0px 35px 7px #cd28fa"",
                    delay: 0.25
                })
                .to(buttonTwo, 0.1, {
                    opacity: 0.5,
                    background: ""#26ff92""
                })
                .to(buttonTwo, 0, {
                    width: 1,
                    delay: 0.2
                })
                // .to(button, 1, {
                //     boxShadow: ""0px 0px 100px 55px #fa2856"",
                //     height: 100,
                //     delay: 0.3
                // })
                .to(buttonTwo, 0.1, {
                    boxShadow: ""0px 0px 100px 55px #fa2856"",
");
            WriteLiteral(@"                    y: 90,
                    height: 100,
                    delay: 0.23
                })
                .to(buttonTwo, 0.3, {
                    height: 1000,
                    y: -1500,
                    boxShadow: ""0px 0px 85px 17px #fa2856"",
                    delay: 0.2
                });

            setTimeout(function () { two(); }, 5000);
        }
        else {
            setTimeout(function () { two(); }, 500);
        }

    });

    buttonThree.addEventListener(""click"", () => {
        if (");
#nullable restore
#line 173 "C:\Users\tjvin\Desktop\repos\NewButtonGame\NewButtonGame\Views\Button\Index.cshtml"
       Write(Button.BadButton);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" == 3) {
            timeLine
                .to("".thank"", 1, {
                    opacity: 1,
                    delay: 0.3
                })
                .to(buttonTextThree, 0.6, {
                    opacity: 0
                })
                .to(buttonThree, 0.8, {
                    height: 0.2,
                    opacity: 0.5,
                    boxShadow: ""0px 0px 35px 7px #cd28fa"",
                    delay: 0.25
                })
                .to(buttonThree, 0.1, {
                    opacity: 0.5,
                    background: ""#26ff92""
                })
                .to(buttonThree, 0, {
                    width: 1,
                    delay: 0.2
                })
                // .to(button, 1, {
                //     boxShadow: ""0px 0px 100px 55px #fa2856"",
                //     height: 100,
                //     delay: 0.3
                // })
                .to(buttonThree, 0.1, {
                    boxShadow: ""0px 0px 100px 55px #");
            WriteLiteral(@"fa2856"",
                    y: 90,
                    height: 100,
                    delay: 0.23
                })
                .to(buttonThree, 0.3, {
                    height: 1000,
                    y: -1500,
                    boxShadow: ""0px 0px 85px 17px #fa2856"",
                    delay: 0.2
                });

            setTimeout(function () { three(); }, 5000);
        }
        else {
            setTimeout(function () { three(); }, 500);
        }

    });

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
