window.carouselInterop = {
    instances: new Map(),

    init: function (element, dotnetHelper) {
        const resizeObserver = new ResizeObserver(entries => {
            for (let entry of entries) {
                dotnetHelper.invokeMethodAsync(
                    'OnResize',
                    entry.contentRect.width
                );
            }
        });

        resizeObserver.observe(element);

        let startX = 0;

        const touchStart = e => {
            startX = e.touches[0].clientX;
        };

        const touchEnd = e => {
            const endX = e.changedTouches[0].clientX;
            const diff = startX - endX;

            if (Math.abs(diff) > 50) {
                diff > 0
                    ? dotnetHelper.invokeMethodAsync('SwipeNext')
                    : dotnetHelper.invokeMethodAsync('SwipePrev');
            }
        };

        element.addEventListener("touchstart", touchStart);
        element.addEventListener("touchend", touchEnd);

        this.instances.set(element, {
            resizeObserver,
            touchStart,
            touchEnd
        });
    },

    dispose: function (element) {
        const instance = this.instances.get(element);
        if (!instance) return;

        instance.resizeObserver.disconnect();
        element.removeEventListener("touchstart", instance.touchStart);
        element.removeEventListener("touchend", instance.touchEnd);

        this.instances.delete(element);
    }
};

// Alias opcional si lo necesitas
window.carouselInterop.observe = function (element, dotnetHelper) {
    window.carouselInterop.init(element, dotnetHelper);
};
