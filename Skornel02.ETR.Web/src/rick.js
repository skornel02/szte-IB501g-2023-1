// @ts-nocheck
// Thank you: https://github.com/Yonle/RickRoll.js/tree/rickrolls

var rickroll = function (opt, customElement) {
    if (typeof (opt) !== 'object') {
        opt = { click: true };
    };

    const element = customElement ?? window;

    if (opt && typeof (opt) === 'object') {
        if (opt.click) {
            element.onclick = rickroll.showup;
            element.ontouchmove = rickroll.showup;
        };
        if (opt.scroll) element.onscroll = rickroll.showup;
        if (opt.mousemove) element.onmousemove = rickroll.showup;
        if (opt.mouseenter) element.onmouseenter = rickroll.showup;
        if (opt.mouseleave) element.onmouseleave = rickroll.showup;
        if (opt.mousewheel) element.onmousewheel = rickroll.showup;
        if (opt.drag) element.ondrag = rickroll.showup;
        if (opt.select) {
            element.onselect = rickroll.showup;
            element.onselectstart = rickroll.showup;
            element.onselectionchange = rickroll.showup;
        };
        if (opt.input) {
            element.oninput = rickroll.showup;
            element.onkeydown = rickroll.showup;
            element.onkeypress = rickroll.showup;
            element.onkeyup = rickroll.showup;
        };
        if (opt.resize) element.onresize = rickroll.showup;
    };

    return true;
};

rickroll.video = "https://yonle.github.io/RickRoll.js/vid.mp4";
rickroll.showup = async function ShowUp(opt = {}) {
    if (typeof (opt) !== 'object') opt = {}
    if (!opt.force && rickroll.showup.only_once && rickroll.playing) {
        return false;
    }
    var video = document.createElement("video");
    video.load();
    video.src = opt.src || rickroll.video;
    video.style.display = "block";
    video.style.width = "100%";
    video.style.height = "auto";
    video.style.position = "fixed";
    video.style.top = "0";
    video.style.bottom = "0";
    video.style.left = "0";
    video.style.right = "0";
    video.loop = opt.loop || rickroll.showup.loop || true;
    rickroll.playing = true;
    try {
        await video.play();
        document.open();
        document.appendChild(video);
        document.close();
        return true;
    } catch (error) {
        rickroll.playing = false;
        return error;
    }
};

rickroll.showup.only_once = true;
rickroll.showup.loop = true;
rickroll.playing = false;

export default rickroll;
