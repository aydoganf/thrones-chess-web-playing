#pragma checksum "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abe01d1951514dc59bc6c751e16ab99a9f9bc54d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Session_View), @"mvc.1.0.view", @"/Views/Session/View.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe01d1951514dc59bc6c751e16ab99a9f9bc54d", @"/Views/Session/View.cshtml")]
    public class Views_Session_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/socket.io.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
  
    string socketUrl = "http://localhost:5000";
    string apiUrl = "http://localhost:5005/api/chess"; //"https://thrones-chess-api.herokuapp.com/api/chess";
    string sessionName = ViewBag.SessionName;
    string playerNickname = ViewBag.PlayerNickname;
    ViewData["Title"] = "View";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style type=""text/css"">
    #console {
        font-size: 14px;
        overflow-y: auto;
        height: 640px;
        border: 1px solid #221d1d;
        background: #f3f3f3;
        margin-top: 46px;
        padding-left: 5px;
        margin-bottom: 5px;
    }

    #board td img:hover {
        cursor: pointer;
    }

    .selected-stone {
        border: 2px solid #000 !important;
    }

    .coordinate-x {
        font-size: 13px;
        vertical-align: top;
        height: 30px !important;
    }

    .coordinate-y {
        border-color: #fff !important;
        vertical-align: middle !important;
        font-size: 13px;
    }

    .board-cell {
        width: 103px;
        height: 80px;
        text-align: center
    }

    .player-nickname {
        font-size: 24px;
        font-weight: bold;
        margin-bottom: 10px;
        text-align: center;
    }

    .session-info {
        color: white;
        font-size: 28px;
        text-align: center;
");
            WriteLiteral("        margin-bottom: 20px;\r\n    }\r\n\r\n    #session-warning{\r\n        background:#ee2c08;\r\n    }\r\n\r\n    #session-turn {\r\n        background: #60bf01;\r\n    }\r\n</style>\r\n\r\n<h1>Chess Session</h1>\r\n<hr />\r\n");
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12 session-info"" id=""session-warning"" style=""display:none;""></div>
        <div class=""col-md-12 session-info"" id=""session-turn"" style=""display:none;""></div>
    </div>
    <div class=""row"">
        <div class=""col-md-9"">

            <div class=""player-nickname"" id=""player0""></div>
            <table class=""table table-bordered"" id=""board"">

");
#nullable restore
#line 84 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                 for (int y = 8; y > 0; y--)
                {
                    var bg = "#d18b47";



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"coordinate-y\">\r\n                            ");
#nullable restore
#line 91 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                       Write(y);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 93 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                         for (int x = 1; x <= 8; x++)
                        {
                            bg = (y + x) % 2 == 0 ? "#d18b47" : "#ffce9e";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"board-cell\"");
            BeginWriteAttribute("style", " style=\"", 2439, "\"", 2462, 3);
            WriteAttributeValue("", 2447, "background:", 2447, 11, true);
#nullable restore
#line 96 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
WriteAttributeValue("", 2458, bg, 2458, 3, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2461, ";", 2461, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-x=\"");
#nullable restore
#line 96 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                                                                              Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-y=\"");
#nullable restore
#line 96 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                                                                                          Write(y);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></td>\r\n");
#nullable restore
#line 97 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 99 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
            <table>
                <tr>
                    <td class=""coordinate-y"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td class=""board-cell coordinate-x"">a</td>
                    <td class=""board-cell coordinate-x"">b</td>
                    <td class=""board-cell coordinate-x"">c</td>
                    <td class=""board-cell coordinate-x"">d</td>
                    <td class=""board-cell coordinate-x"">e</td>
                    <td class=""board-cell coordinate-x"">f</td>
                    <td class=""board-cell coordinate-x"">g</td>
                    <td class=""board-cell coordinate-x"">h</td>
                </tr>
            </table>
            <div class=""player-nickname"" id=""player1""></div>
        </div>
        <div class=""col-md-3"">
            <div id=""console"" ></div>
            <div>
                <div class=""input-group"">
                    <input type=""text"" class=""form-control"" id=""chat-text"" />
            ");
            WriteLiteral(@"        <div class=""input-group-append"">
                        <button type=""button"" class=""btn btn-outline-secondary"" id=""send-chat"">Chat</button>
                    </div>
                </div>
                
            </div>
        </div>
    </div>
");
            WriteLiteral("\r\n<input type=\"hidden\" id=\"session-name\" />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abe01d1951514dc59bc6c751e16ab99a9f9bc54d9910", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abe01d1951514dc59bc6c751e16ab99a9f9bc54d10949", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n\r\n    let socket = {};\r\n    let player = \'");
#nullable restore
#line 140 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
             Write(playerNickname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    let currentIndexer = 0;
    let session = null;
    let xCoordinates = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'];
    let checkmate = false;

    let selectedStone = {
        type: '',
        color: '',
        location: {
            x: 0,
            y: 0
        },
        assignFrom: function (stoneInfo) {
            this.type = stoneInfo.type;
            this.color = stoneInfo.color;
            this.location.x = stoneInfo.location.split('|')[0];
            this.location.y = stoneInfo.location.split('|')[1];
        },
        move: function (x, y) {

            let from = xCoordinates[this.location.x - 1] + '' + this.location.y;
            let to = xCoordinates[x - 1] + '' + y;
            let command = from + "" "" + to;

            $.ajax({
                url: '");
#nullable restore
#line 166 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                contentType: \'application/json;charset=utf-8\',\r\n                dataType: \'json\',\r\n                method: \'POST\',\r\n                headers: { SessionName: \'");
#nullable restore
#line 170 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                                    Write(sessionName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' },
                processData: false,
                data: '{""command"":""' + command + '""}',
                success: function (response) {
                    session = response;

                    if (session.movementResult.isOK) {
                        // remove current
                        selectedStone.removeCurrentLocation();
                        selectedStone.release();

                        setTurn();
                        drawTable();
                    }                    
                },
                error: function (xhr, textStatus, errorThrown) {
                    addToConsole('error occured');
                },
                complete: function (xhr, textStatus) {
                }
            });

        },
        removeCurrentLocation: function () {
            $('#board td[data-x=""' + this.location.x + '""][data-y=""' + this.location.y + '""] img').remove();
        },
        release: function () {
            this.type = '';
         ");
            WriteLiteral("   this.color = \'\';\r\n            this.location.x = 0;\r\n            this.location.y = 0;\r\n        }\r\n    };\r\n\r\n\r\n    $(document).ready(function () {\r\n\r\n        $(\'#session-name\').val(\'");
#nullable restore
#line 207 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                           Write(sessionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n\r\n        // #region socket\r\n        socket = io(\'");
#nullable restore
#line 210 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                Write(socketUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', {\r\n            cors: {\r\n                withCredentials: true\r\n            }\r\n        });\r\n\r\n        socket.emit(\'join-session\', \'");
#nullable restore
#line 216 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                                Write(sessionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 216 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                                                Write(playerNickname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');

        socket.on('chat-message', function (message, nickname) {
            addToConsole('<strong>' + nickname + ':</strong> ' + message);
        });

        socket.on('movement-done', function (current, next, movementResult) {

            $('#session-warning').hide();

            let commandInfo = '<strong>' + current + '</strong> oyuncusu <strong>' + movementResult.command + '</strong> oynadı.';
            addToConsole(commandInfo);

            if (movementResult.check) {
                $('#session-warning').html('Check !').show();
            }

            if (movementResult.checkmate) {

                checkmate = true;
                $('#session-warning').html('Checkmate !').show();

                let message = '<strong>' + current + '</strong> has beated the <strong>' + next + '</strong>';
                addToConsole(message);
            }

            if (movementResult.checkmate == false) {

                console.log(movementResult);
                a");
            WriteLiteral("ddToConsole(\'Sıra <strong>\' + next + \'</strong> oyuncusunda.\');\r\n\r\n                if (next.toLowerCase() == \'");
#nullable restore
#line 247 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                                      Write(playerNickname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"') {
                    $('#session-turn').html('Sıra sende !').show();
                } else {
                    $('#session-turn').hide();
                }
            }
                

            getSession();
        });

        $('#send-chat').click(function () {
            socket.emit('chat-message', '");
#nullable restore
#line 259 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                                    Write(sessionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', $(\'#chat-text\').val(), \'");
#nullable restore
#line 259 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                                                                           Write(playerNickname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
            $('#chat-text').val('');
        });
        // #endregion

        // #region chat
        $('#chat-text').keydown(function (e) {
            // enter
            if (e.originalEvent.keyCode === 13) {
                $('#send-chat').trigger('click');
            }

        });
        // #endregion

        // #region game session
        getSession();
        // #endregion

        $(document).on('click', '#board td img', function () {
            
            if (checkmate) {
                return;
            }

            let x = $(this).parent().data('x');
            let y = $(this).parent().data('y');

            let type = $(this).data('type');
            let color = $(this).data('color');
            let colorIndex = color === 'Black' ? 0 : 1;
            let isMyStone = player.toLowerCase() == session.players[colorIndex].nickname.toLowerCase();

            if (isMyStone) {
                // clear all selecteds
                $('.selected-sto");
            WriteLiteral(@"ne').removeClass('selected-stone');

                // add selection to current stone
                $(this).parent().addClass('selected-stone');

                // assign selectedStone
                selectedStone.type = type;
                selectedStone.color = color;
                selectedStone.location.x = x;
                selectedStone.location.y = y;
            }
        });

        $(document).on('click', '#board td', function () {

            if (checkmate == false) {
                let x = $(this).data('x');
                let y = $(this).data('y');

                if (selectedStone.type !== '' && !(selectedStone.location.x == x && selectedStone.location.y == y)) {
                    selectedStone.move(x, y);
                }
            }
            
        });
    });


    function getSession() {
        $.ajax({
            url: '");
#nullable restore
#line 324 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
             Write(apiUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            contentType: \'application/json;charset=utf-8\',\r\n            dataType: \'json\',\r\n            method: \'GET\',\r\n            headers: { SessionName: \'");
#nullable restore
#line 328 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                                Write(sessionName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' },
            success: function (data) {
                console.log(data);

                if (session == null) {

                    session = data;

                    let current = getCurrentPlayer();
                    addToConsole('Sıra <strong>' + current + '</strong> oyuncusunda.');
                }

                session = data;
                sessionCreate();
                drawTable();
            },
            error: function (xhr, textStatus, errorThrown) {
                console.log(errorThrown);
            },
            complete: function (xhr, textStatus) {
                if (textStatus === ""success"") {

                }
            }
        });
    }

    function setTurn() {
        socket.emit('movement-done', '");
#nullable restore
#line 356 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                                 Write(sessionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 356 "C:\Users\faruk\source\repos\thrones-chess-web-playing\WebPlaying\WebChessPlaying\Views\Session\View.cshtml"
                                                 Write(playerNickname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', getCurrentPlayer(), session.movementResult);
    }

    function sessionCreate() {

        $('#player0').text(session.players[0].nickname);
        $('#player1').text(session.players[1].nickname);

    }

    function getCurrentPlayer() {
        return session.players[session.currentIndexer].nickname;
    }

    function clearTable() {
        //$('#session-warning').hide();
        $('#board td img').remove();
    }

    function drawTable() {
        clearTable();

        for (var i = 0; i < session.table.stones.length; i++) {
            let stoneInfo = session.table.stones[i];

            let stoneName = stoneInfo.type.toLowerCase() + '-' + stoneInfo.color.toLowerCase();
            let icon = '/lib/icons/' + stoneName + '.png';
            let locationX = stoneInfo.location.split('|')[0];
            let locationY = stoneInfo.location.split('|')[1];

            $('#board td[data-x=""' + locationX + '""][data-y=""' + locationY + '""]')
                .html(""<img src='"" ");
            WriteLiteral(@"+ icon + ""' data-type='"" + stoneInfo.type + ""' data-color='"" + stoneInfo.color + ""' data-location='"" + stoneInfo.location + ""' data-stone='"" + stoneName + ""' />"");
        }

        if (session.movementResult) {

            if (session.movementResult.location) {
                let x = session.movementResult.location.x;
                let y = session.movementResult.location.y;

                // clear all selecteds
                $('.selected-stone').removeClass('selected-stone');

                $('#board td[data-x=""' + x + '""][data-y=""' + y + '""]').addClass('selected-stone');
            }

        }
    }

    function addToConsole(message) {
        let now = new Date();
        let time = now.toTimeString().split(' ')[0];

        $('#console').append('<p>[' + time + ']: ' + message + '</p>');
        $('#console').append('<hr />');
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
