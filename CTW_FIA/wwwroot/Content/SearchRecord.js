if (v.desTableName == response.tableName) {
    if (v.srcTableName == 'MediaFile' || v.desTableName == 'MediaFile') {
        //$("#media_ul_id").append('<li class=nav-item><a href=' + v.strURNSource + '>' + v.srcTableName + '</a><i class="fa-solid fa-arrows-left-right-to-line"></i> <a href=' + v.strURNDest + '>' + v.desTableName + '</a></li>');

        $('#media_ul_id').append("<li class=nav-item> <button class='btn btn-default btn-block' id='" + v.strURNDest + "' data-strURN='" + v.strURNDest + "' data-ctrName='" + src_controllerName + "' >" + v.strURNDest + "</button></li>")


    }
    // else if ($("#" + src_controllerName).length > 0) {
    if (src_controllerName == "People") {
        $('#link_ul_id').append('<li class="nav-item"> <a href=# class=nav-link >   <span class="badge badge-info" id=span_' + src_controllerName + '>1</span> &nbsp <p> Terrorists  <i class="fas fa-angle-left right" aria-hidden="true"></i></p> </a> <ul class="nav nav-treeview" id=' + src_controllerName + '></ul>');
        $('#' + src_controllerName).append("<li class='nav-item' > <button class='btn btn-default btn-block' id='" + v.strURNDest + "' data-strURN='" + v.strURNDest + "' data-ctrName='" + src_controllerName + "' >" + v.strURNDest + "</button></li>")
        ViewByIdDetail(src_controllerName, v.strURNDest)
    }
    else {

        $('#link_ul_id').append('<li class="nav-item"> <a href=# class=nav-link >   <span class="badge badge-info" id=span_' + src_controllerName + '>1</span> &nbsp <p> ' + src_controllerName + '  <i class="fas fa-angle-left right" aria-hidden="true"></i></p> </a> <ul class="nav nav-treeview" id=' + src_controllerName + '></ul>');
        $('#' + src_controllerName).append("<li class='nav-item' > <button class='btn btn-default btn-block' id='" + v.strURNDest + "' data-strURN='" + v.strURNDest + "' data-ctrName='" + src_controllerName + "' >" + v.strURNDest + "</button></li>")
        ViewByIdDetail(src_controllerName, v.strURNDest)

    }
    switch (src_controllerName) {
        case "Incidents":
            $('#' + src_controllerName + response.length).append("<li class=nav-item> <button class='btn btn-default btn-block text-left' id='" + v.strURNDest + "' data-strURN='" + v.strURNDest + "' data-ctrName='" + src_controllerName + "' >" + v.strOperationName + "</button></li>")
            break;
        case "Address":
            $('#' + src_controllerName + response.length).append("<li class=nav-item> <button class='btn btn-default btn-block text-left' id='" + v.strURNDest + "' data-strURN='" + v.strURNDest + "' data-ctrName='" + src_controllerName + "' >" + v.memRemarks + "</button></li>")

            break;
        case "People":
            $('#' + src_controllerName + response.length).append("<li class=nav-item> <button class='btn btn-default btn-block text-left' id='" + v.strURNDest + "' data-strURN='" + v.strURNDest + "' data-ctrName='" + src_controllerName + "' >" + v.name + "</button></li>")

            break;
        case "Explosives":
            $('#' + src_controllerName + response.length).append("<li class=nav-item> <button class='btn btn-default btn-block text-left' id='" + v.strURNDest + "' data-strURN='" + v.strURNDest + "' data-ctrName='" + src_controllerName + "' >" + v.strURN + "</button></li>")

            break;
        default:
            $('#' + src_controllerName).append("<li class=nav-item> <button class='btn btn-default btn-block' id='" + v.strURNDest + "' data-strURN='" + v.strURNDest + "' data-ctrName='" + src_controllerName + "' >" + v.strURNDest + "</button></li>")
            break;
    }
    //$('#' + src_controllerName).append("<li class=nav-item> <button class='btn btn-default btn-block' id='" + v.strURNDest + "' data-strURN='" + v.strURNDest + "' data-ctrName='" + src_controllerName + "' >" + v.strURNDest + "</button></li>")
    ViewByIdDetail(src_controllerName, v.strURNDest)


    var count_n = $("#" + src_controllerName + " li").length
    // alert("#" + src_controllerName +" li")
    console.log(count_n);
    $("#span_" + src_controllerName).html(count_n)

}