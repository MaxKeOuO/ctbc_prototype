var modalAlertBox = modalAlertBox || (function () {

    function setTitle(title) {

        $('#modalAlertBoxLabel').text(title);
    }

    function setContent(content) {

        $('#errorMessage').text(content);
    }

    function setOkEvent(eventOk) {
        $('#confirmBtn').off('click');
        $('#confirmBtn').click(eventOk);
    }

    function setHideEvent(event) {
        $('#modalAlertBox').off('hidden.bs.modal');
        $('#modalAlertBox').on('hidden.bs.modal', event);
    }

    function openContainer() {

        $('#modalAlertBox').modal('show');
    }

    function closeContainer() {
        $('#modalAlertBox').modal('hide');
    }

    return {
        open: function (title, content, hideEvent, btnOKEvent) {

            setTitle(title);

            setContent(content);

            setHideEvent(hideEvent);

            setOkEvent(btnOKEvent);           

            openContainer();
        },
        close: closeContainer,
    };

})();

var modalDialogBox = modalDialogBox || (function () {

    function setTitle(title) {

        $('#modalDialogBoxLabel').text(title);
    }

    function setContent(content) {

        $('#dialogErrorMessage').text(content);
    }

    function openContainer() {

        $('#modalDialogBox').modal('show');
    }

    function closeContainer() {
        $('#modalDialogBox').modal('hide');
    }

    function setHideEvent(event) {
        $('#modalDialogBox').on('hidden.bs.modal', event);
    }

    function setOkEvent(eventOk) {
        $('#btnDialogOk').off('click');
        $('#btnDialogOk').click(eventOk);
    }

    function setCancelEvent(eventCancel) {
        $('#btnDialogCancel').off('click');
        $('#btnDialogCancel').click(eventCancel);
    }

    return {
        open: function (title, content, hideEvent, btnOKEvent , btnCancelEvent) {

            setTitle(title);

            setContent(content);

            setHideEvent(hideEvent);

            setOkEvent(btnOKEvent);

            setCancelEvent(btnCancelEvent);

            openContainer();
        },
        close: closeContainer,

    };

})();