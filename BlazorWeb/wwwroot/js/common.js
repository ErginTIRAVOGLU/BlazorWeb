window.showToastr = function (type, message, title) {
    switch (type) {
        case 'success':
            toastr.success(message, title);
            break;
        case 'info':
            toastr.info(message, title);
            break;
        case 'warning':
            toastr.warning(message, title);
            break;
        case 'error':
            toastr.error(message, title);
            break;
        default:
            console.error('Unknown toastr type: ' + type);
    }
}

window.ShowSwal = function (title, message, icon) {
    Swal.fire({
        title: title,
        text: message,
        icon: icon,
        confirmButtonText: 'OK'
    });
}