$(function () {
    var placeholderElement = $('#modal-placeholder');

    $('button[data-toggle="ajax-modal"]').click(function (event) {
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            placeholderElement.html(data);
            placeholderElement.find('.modal').modal('show');
        });
    });


    // site.js
    // attach click event handler to an element
    // which is located inside #modal-placeholder
    // and has data-save attribute equal to modal
    //What’s the next step ? Well, we need to get form data and then send it.
   // We’re simply going to navigate DOM in order to find a form tag located inside the modal.Then we’ll extract form action url.We’re going to get form data and make it eligible for sending(serialization) 
   //then we’re going to send the data to server.Once we receive response we’re going to close the modal.


    placeholderElement.on('click', '[data-save="modal"]', function (event) {
        event.preventDefault();

        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var dataToSend = form.serialize();

        $.post(actionUrl, dataToSend).done(function (data) {
            placeholderElement.find('.modal').modal('hide');
        });
    });

  
});