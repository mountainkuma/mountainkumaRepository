using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StackQueue
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region Static
		/// <summary>
		/// スタック長
		/// </summary>
		static readonly int LENGTH_STACK = 5;
		/// <summary>
		/// キュー長
		/// </summary>
		static readonly int LENGTH_QUEUE = 5;
		#endregion

		#region Field
		string[] stack = null;
		string[] queue = null;

		int idxStack = 0;
		int idxEnQueue = 0;
		int idxDeQueue = 0;
		#endregion

		#region LogicalMethod
		/// <summary>
		/// Push
		/// </summary>
		/// <param name="num"></param>
		private void Push(string num)
		{
			stack[idxStack] = num;

			if (idxStack < LENGTH_QUEUE - 1)
			{
				idxStack++;
			}
		}

		/// <summary>
		/// Pop
		/// </summary>
		/// <returns></returns>
		private string Pop()
		{
			if (this.isNeededDecrementByStack())
			{
				idxStack--;
			}

			string buf = stack[idxStack];
			stack[idxStack] = "";

			return buf;
		}

		/// <summary>
		/// EnQueue
		/// </summary>
		/// <param name="num"></param>
		private void EnQueue(string num)
		{
			if (!string.IsNullOrEmpty(queue[idxEnQueue])) { return; }

			queue[idxEnQueue] = num;

			idxEnQueue = (idxEnQueue + 1) % LENGTH_QUEUE;
		}

		/// <summary>
		/// DeQueue
		/// </summary>
		/// <returns></returns>
		private string DeQueue()
		{
			if (string.IsNullOrEmpty(queue[idxDeQueue])) { return ""; }

			string buf = queue[idxDeQueue];

			queue[idxDeQueue] = "";

			idxDeQueue = (idxDeQueue + 1) % LENGTH_QUEUE;

			return buf;
		}

		#endregion

		#region IOMethod
		/// <summary>
		/// スタック出力
		/// </summary>
		private void ExportStack()
		{
			var stackFormat = new string[LENGTH_STACK];

			this.stack.CopyTo(stackFormat, 0);

			// Pop対象に[]を付ける
			if (this.stack.Any(x => x != ""))
			{
				if (this.isNeededDecrementByStack())
				{
					stackFormat[idxStack - 1] = $"[{stackFormat[idxStack - 1]}]";
				}
				else
				{
					stackFormat[idxStack] = $"[{stackFormat[idxStack]}]";
				}
			}

			var nums = stackFormat.Select(num => $"{num}, ");

			var builder = new StringBuilder();

			foreach (var num in nums)
			{
				builder.Append(num);
			}

			this.lblStack.Text = builder.ToString();
		}

		/// <summary>
		/// キュー出力
		/// </summary>
		private void ExportQueue()
		{
			var queueFormat = new string[LENGTH_QUEUE];

			this.queue.CopyTo(queueFormat, 0);

			if (this.queue.Any(x => x != ""))
			{
				queueFormat[idxDeQueue] = $"[{queueFormat[idxDeQueue]}]";
			}

			var nums = queueFormat.Select(num => $"{num}, ");

			var builder = new StringBuilder();

			foreach (var num in nums)
			{
				builder.Append(num);
			}

			this.lblQueue.Text = builder.ToString();
		}
		#endregion

		#region UtillityMethod
		/// <summary>
		/// 数値かの確認
		/// </summary>
		/// <returns></returns>
		private bool isNum(string val)
		{
			int pushNum = 0;
			if (!int.TryParse(val, out pushNum)) { return false; }

			return true;
		}

		/// <summary>
		/// スタックがデクリメント必要かの確認
		/// </summary>
		/// <returns></returns>
		private bool isNeededDecrementByStack()
		{
			if (0 < idxStack && idxStack < LENGTH_STACK - 1
			|| idxStack == LENGTH_STACK - 1 && string.IsNullOrEmpty(this.stack[idxStack]))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// テキストボックスへのフォーカス
		/// </summary>
		/// <param name="txtBox"></param>
		private void TextFocus(TextBox txtBox)
		{
			txtBox.Focus();
			txtBox.SelectAll();
		}
		#endregion

		#region Event
		/// <summary>
		/// ページロード処理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Page_Load(object sender, EventArgs e)
		{
			this.stack = new string[LENGTH_STACK];
			this.queue = new string[LENGTH_QUEUE];

			this.stack.Select(x => "");
			this.queue.Select(x => "");
		}

		/// <summary>
		/// Pushボタン押下イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnPush_Click(object sender, EventArgs e)
		{
			if (!this.isNum(this.txtStack.Text)) { return; }

			this.Push(this.txtStack.Text);

			this.ExportStack();

			this.TextFocus(txtStack);
		}

		/// <summary>
		/// Popボタン押下イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnPop_Click(object sender, EventArgs e)
		{
			this.txtStack.Text = this.Pop();

			this.ExportStack();

			this.TextFocus(txtStack);
		}

		/// <summary>
		/// EnQueueボタン押下イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnEnQueue_Click(object sender, EventArgs e)
		{
			if (!this.isNum(this.txtQueue.Text)) { return; }

			this.EnQueue(this.txtQueue.Text);

			this.ExportQueue();

			this.TextFocus(txtQueue);
		}

		/// <summary>
		/// DeQueueボタン押下イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDeQueue_Click(object sender, EventArgs e)
		{
			this.txtQueue.Text = this.DeQueue();

			this.ExportQueue();

			this.TextFocus(txtQueue);
		}

		/// <summary>
		/// テキストボックス押下イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtStack_Click(object sender, EventArgs e)
		{
			var txtBox = (TextBox)sender;

			txtBox.SelectAll();
		}
		#endregion
	}
}
