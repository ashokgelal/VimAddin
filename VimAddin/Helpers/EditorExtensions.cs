using System;
using Mono.TextEditor;

namespace VimAddin.Helpers
{
    public static class EditorExtensions
    {
        public static int CharIndexBeforeCaret(this TextEditor editor, char ch)
        {
            var lineSegment = editor.Document.GetLine(editor.Caret.Line);
            var text = editor.Document.GetTextBetween(lineSegment.Offset, editor.Caret.Offset);
            return text.Length == 0 ? -1 : text.LastIndexOf(ch, text.Length - 1);
        }

        public static int CharIndexAfterCaret(this TextEditor editor, char ch)
        {
            var lineSegment = editor.Document.GetLine(editor.Caret.Line);
            var text = editor.Document.GetTextBetween(editor.Caret.Offset, lineSegment.EndOffset);
            return text.Length == 0 ? -1 : text.IndexOf(ch, 1);
        }
    }
}

