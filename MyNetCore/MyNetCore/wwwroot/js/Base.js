
function ShowMessage(message, type) {
    base.$message({ message: message, type: type });
}

var base = new Vue({
    methods: { 
        ShowError: function (message) {
            ShowMessage(message, "warning");
        },
        ShowSuccess: function (message) {
            ShowMessage(message, "success");
        }
    }
})
