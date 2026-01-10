window.carouselResize = {
    register: function (dotNetRef) {

        function notify() {
            dotNetRef.invokeMethodAsync(
                'OnResize',
                window.innerWidth
            );
        }

        // Inicial
        notify();

        // Escucha resize
        window.addEventListener('resize', notify);
    }
};
