function AttachmentControl() {
    document.write("<iframe id=\"AttachmentFrame\" scrolling=\"no\" width=\"0\" height=\"0\" style=\" border:0px 0px 0px 0px; margin:0px 0px 0px 0px; padding:0px 0px 0px 0px;\" ></iframe>");
}
function AttachmentExport(AttachmentID) {
    document.getElementById("AttachmentFrame").src = "Handler/AttachmentHandler.ashx?AttachmentID=" + AttachmentID;
}
function AttachmentExport(Path, AttachmentID) {
    document.getElementById("AttachmentFrame").src = Path + "/AttachmentHandler.ashx?AttachmentID=" + AttachmentID;

}
$(document).ready(function() {

});

