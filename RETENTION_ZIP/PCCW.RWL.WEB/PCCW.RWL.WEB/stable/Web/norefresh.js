var oLastBtn=0;
bIsMenu = false;
//No RIGHT CLICK************************
if (window.Event) 
	document.captureEvents(Event.MOUSEUP); 

function nocontextmenu(){ 
	event.cancelBubble = true 
	event.returnValue = false; 
	return false; 
} 
function norightclick(e){ 
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
document.oncontextmenu = nocontextmenu; 
document.onmousedown = norightclick; 

// Block backspace onKeyDown************
function document.onkeydown() {
	s=window.event.keyCode
	if (s==18) {
		alert('CSC Web Page')
		return false
	}
	if ( (event.altKey) || ((event.keyCode == 8) && (event.srcElement.type != "text" && event.srcElement.type != "textarea" && event.srcElement.type != "password")) || ((event.ctrlKey) && ((event.keyCode == 68) || (event.keyCode == 78) || (event.keyCode == 82)) ) || (event.keyCode == 116) || (event.keyCode == 122) ) {
		event.keyCode = 0;
		event.returnValue = false;
	}
}
