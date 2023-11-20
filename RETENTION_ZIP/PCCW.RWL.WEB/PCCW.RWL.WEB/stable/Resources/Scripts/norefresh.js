var oLastBtn=0;
bIsMenu = false;
//No RIGHT CLICK************************
if (window.Event) {
    try {
        document.captureEvents(Event.MOUSEUP);
    } catch (e) {

    }
}
function nocontextmenu() {
    try {
        event.cancelBubble = true
        event.returnValue = false;
    }
    catch (e) {

    }
	return false; 
}
function norightclick(e) { 
     try {
	    if (window.Event){ 
		    if (e.which !=1) 
			    return false; 
	    } 
	    else if (event.button !=1) { 
		    event.cancelBubble = true 
		    event.returnValue = false; 
		    return false; 
	    } 
	}
	catch (e) {

	}
} 
document.oncontextmenu = nocontextmenu; 
document.onmousedown = norightclick; 

// Block backspace onKeyDown************
document.onkeydown = function () {
    try {
        s = window.event.keyCode
        if (s == 18) {
            alert('CSC Web Page')
            return false
        }
        if ((event.altKey) || ((event.keyCode == 8) && (event.srcElement.type != "text" && event.srcElement.type != "textarea" && event.srcElement.type != "password")) || ((event.ctrlKey) && ((event.keyCode == 68) || (event.keyCode == 78) || (event.keyCode == 82))) || (event.keyCode == 116) || (event.keyCode == 122)) {
            event.keyCode = 0;
            event.returnValue = false;
        }
    }
    catch (e) {

    }
};
