namespace Sudoku.Constants
{
    /// <summary>
    /// Constants used across the application files.
    /// </summary>
    public class FormConstants
    {
        // Grid Modes
        public const string Easy = "Dễ";
        public const string Medium = "Trung bình";
        public const string Hard = "Khó";

        // Messages
        public const string PuzzleGenerated = "Đã tạo bảng Sudoku!";
        public const string PuzzleSolved = "Đã giải xong!";
        public const string PuzzleCleared = "Bảng Sudoku đã được làm trống!";
        public const string CongratulationsMessage = "Xin chúc mừng bạn đã hoàn thành vòng này!"; //"Chúc mừng thằng em đã giải được nhé";
        public const string PuzzleGridEmpty = "Ô bảng Sudoku đang trống";
        public const string PuzzleInvalidSolve = "Xin lỗi, bạn đã giải sai rồi. Chúc bạn may mắn lần sau";
        public const string PuzzleValidButNotCompleted = "Tình trạng hiện tại của bảng Sudoku đang đúng nhưng chưa hoàn thành";
        public const string PuzzleInvalidSolveState = "Tình trạng hiện tại của bảng Sudoku đang sai, hãy thử lại";
        public const string PuzzleNoSolution = "Không thể giải bảng Sudoku này";

        //Fonts
        public const string FontFamily = "Maiandra GD";
    }
}