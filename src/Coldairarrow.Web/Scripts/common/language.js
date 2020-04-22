//写入cookie函数
function setCookie(name, value) {
    /*var Days = 30;
    var exp = new Date();
    exp.setTime(exp.getTime() + Days*24*60*60*1000);
    document.cookie = name + "="+ escape (value) + ";expires=" + exp.toGMTString();*/
    //跨iframe页传值
    sessionStorage.setItem("language", value);
    window.location.href = "/user/content?language=" + value;
}

//获取cookie
function getCookie(name) {
    /*var arr,reg=new RegExp("(^| )"+name+"=([^;]*)(;|$)");
    if(arr=document.cookie.match(reg))
    return unescape(arr[2]);
    else
    return null;*/
    return sessionStorage.getItem("language");
}

//setCookie('lan','hk');    //繁体中文
//setCookie('lan','cn');    //简体中文
//setCookie('lan','en');    //英文
//定义语言的标识+内容的json字符串
var cn = null;
var en = null;

$(function () {
    initLAN();
    initTranslate('[set-lan]');
});

//遍历带set-lan属性的标签，进行文本替换
function initTranslate(target) {
    $(target).each(function () {
        var me = $(this);
        var a = me.attr('set-lan').split(';');
        for (var i = 0; a.length > i; i++) {
            var b = a[i].split(':');
            var p = b[0];   //文字放置位置
            var m = b[1];   //文字的标识

            //用户选择语言后保存在cookie中，这里读取cookie中的语言版本
            var lan = getCookie('lan');
            //选取语言文字
            switch (lan) {
                case 'cn':
                    var t = cn[m];  //这里cn[m]中的cn是上面定义的json字符串的变量名，m是json中的键，用此方式读取到json中的值
                    break;
                case 'en':
                    var t = en[m];
                    break;
                default:
                    var t = cn[m];
            }

            if (t == undefined) continue;   //如果还是没有就跳出

            //文字放置位置有（html,val等，可以自己添加）
            switch (p) {
                case 'html':
                    me.html(t);
                    break;
                case 'text':
                    me.text(t);
                    break;
                case 'val':
                case 'value':
                    me.val(t);
                    break;
                case 'title':
                    me.attr('title', t);
                    break;
                case 'tabname':
                    me.attr('tabname', t);
                    break;
                case 'url':
                    me.attr('url', me.attr('url') + "?language=" + lan);
                    break;
                case 'placeholder':
                    me.attr('placeholder', t);
                    break;
                default:
                    me.html(t);
            }
        }
    });
}

//初始化翻译池
function initLAN() {
    var lan = getCookie('lan');
    if (cn == null && (lan == "cn" || lan == null || lan == "null" || lan == "")) {
        $.ajax({
            type: 'get',
            url: "/user/getLanguageTranslationList",
            data: { "language": 'cn' },
            async: false,
            success: function (data) {
                cn = JSON.parse(data);
            },
            error: function () {
                $.jGrowl(get_lan('operationAbnormal'));
            }
        });
    }
    if (en == null && lan == "en") {
        $.ajax({
            type: 'get',
            url: "/user/getLanguageTranslationList",
            data: { "language": 'en' },
            async: false,
            success: function (data) {
                en = JSON.parse(data);
            },
            error: function () {
                $.jGrowl(get_lan('operationAbnormal'));
            }
        });
    }
}

//JS翻译文本调的函数
function get_lan(m, chinese) {
    initLAN();
    //获取文字
    var lan = getCookie('lan');     //语言版本
    //选取语言文字
    switch (lan) {
        case 'cn':
            var t = cn[m];
            break;
        case 'en':
            var t = en[m];
            break;
        default:
            var t = cn[m];
    }
    if (t == undefined) t = chinese; //如果没有就返回指定文案
    return t;
}