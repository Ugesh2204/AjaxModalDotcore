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




        //Once user presses Save button a request is made to HomeController / Contact action.Action validates
        //it and if everything is OK saves it into static list.Then it returns a view(full modal HTML), including errors if validation failed.Then we receive response inside script.We need to extract
       //modal body from the response and replace current modal body with the one from response.

        $.post(actionUrl, dataToSend).done(function (data) {
            var newBody = $('.modal-body', data);
             // find IsValid input field and check it's value
        // if it's valid then hide modal window
            placeholderElement.find('.modal-body').replaceWith(newBody);

            var isValid = newBody.find('[name="IsValid"]').val() == 'True';

            if (isValid) {
                placeholderElement.find('.modal').modal('hide');
            }
        });
    });

  
});