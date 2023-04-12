//If chatButton is clicked get value of chatInput and send it to the server
chatButton.onClick.AddListener(() => {
    if (chatInput.text != "") {
        //disable chatInput
        chatInput.interactable = false;
        //Send message to server
        socket.Emit("chat message", chatInput.text);
        //place message in Div ChatBox 
        chatBox.text += "You: " + chatInput.text + "
        //Clear chatInput   
        chatInput.text = "";
        //enabel chatInput
        chatInput.interactable = true;
    }
});



