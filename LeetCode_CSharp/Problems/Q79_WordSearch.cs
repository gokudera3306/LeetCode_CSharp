using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    public class Q79_WordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            var firstChar = word[0];

            for (var row = 0; row < board.Length; row++)
            {
                for (var col = 0; col < board[0].Length; col++)
                {
                    if (board[row][col] != firstChar) continue;

                    var hasBeen = new bool[board.Length, board[0].Length];
                    var result = FindWord(board, row, col, word, 0, hasBeen);
                    if (result) return true;
                }
            }

            return false;
        }

        private bool FindWord(char[][] board, int row, int col, string word, int charIndex, bool[,] hasBeen)
        {
            if (row < 0 || col < 0 || row > board.Length - 1 || col > board[0].Length - 1) return false;
            if (hasBeen[row, col]) return false;

            if (word[charIndex] != board[row][col]) return false;
            if (charIndex == word.Length - 1) return true;
            
            hasBeen[row, col] = true;
            charIndex++;

            if (FindWord(board, row - 1, col, word, charIndex, hasBeen)) return true;
            if (FindWord(board, row, col - 1, word, charIndex, hasBeen)) return true;
            if (FindWord(board, row + 1, col, word, charIndex, hasBeen)) return true;
            if (FindWord(board, row, col + 1, word, charIndex, hasBeen)) return true;

            hasBeen[row, col] = false;
            return false;
        }
    }
}
