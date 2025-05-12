window.initializeImageZoom = (containerId, imageSelector) => {
    const container = document.getElementById(containerId);
    const imageElement = container ? container.querySelector(imageSelector) : null;

    if (container && imageElement) {
        // Ensure previous zoom instances are cleaned up if any
        // (js-image-zoom might not have a built-in cleanup, depends on library)
        // For simplicity, we assume re-initialization is okay or handle outside if needed.

        const options = {
            // width: 0, // If 0, it will use image width
            // height: 0, // If 0, it will use image height
            // zoomWidth: 500, // Optional: specify zoom area width
            img: imageElement.src,
            offset: { vertical: 0, horizontal: 10 },
            zoomPosition: 'right', // Or 'left', 'top', 'bottom'
            // scale: 1.5 // Optional: zoom scale factor
            fillContainer: true, // Let CSS handle sizing, zoom library adapts
        };

        // Check if ImageZoom is available
        if (typeof ImageZoom !== 'undefined') {
             try {
                new ImageZoom(container, options);
             } catch (e) {
                console.error("Error initializing ImageZoom: ", e);
             }
        } else {
            console.error("ImageZoom library not loaded.");
        }
    } else {
        if (!container) console.error(`Image zoom container not found: #${containerId}`);
        if (!imageElement) console.error(`Image element not found within container: ${imageSelector}`);
    }
};

