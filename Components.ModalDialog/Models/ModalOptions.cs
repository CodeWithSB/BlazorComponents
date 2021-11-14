public class DialogOptions{
    public bool IsBackDropClickCloseAllowed { get; set; }
    public bool ShowHeader { get; set; } = true;
    public string HeaderText { get; set; }
    public bool ShowFooter { get; set; } = true;
    public bool ShowCornerClose { get; set; } = true;
    public bool ShowFooterClose { get; set; }
    public bool ShowFooterSubmit { get; set; }

    public string CloseButtonText { get; set; } = "Close";
    public string SubmitButtonText { get; set; } = "Submit";

}