window.carouselInterop = {
    observe: function (element, dotnetHelper) {
        const observer = new ResizeObserver(entries => {
            for (let entry of entries) {
                dotnetHelper.invokeMethodAsync(
                    'OnResize',
                    entry.contentRect.width
                );
            }
        });
        observer.observe(element);
    },

    enableSwipe: function (element, dotnetHelper) {
        let startX = 0;

        element.addEventListener("touchstart", e => {
            startX = e.touches[0].clientX;
        });

        element.addEventListener("touchend", e => {
            const endX = e.changedTouches[0].clientX;
            const diff = startX - endX;

            if (Math.abs(diff) > 50) {
                if (diff > 0) {
                    dotnetHelper.invokeMethodAsync('SwipeNext');
                } else {
                    dotnetHelper.invokeMethodAsync('SwipePrev');
                }
            }
        });
    }
};
