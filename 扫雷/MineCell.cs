using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace 扫雷
{
    /// <summary>
    /// 继承 PictureBox
    /// </summary>
    class MineCell : PictureBox
    {
        /// <summary>
        /// 是否为地雷
        /// </summary>
        public bool IsMine { get; set; }

        /// <summary>
        /// 是否标记
        /// </summary>
        public bool Marked { get; set; }

        /// <summary>
        /// 是否打开
        /// </summary>
        public bool Open { get; set; }

        #region 官方方法

        public override AnchorStyles Anchor { get => base.Anchor; set => base.Anchor = value; }
        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = value; }
        public override Point AutoScrollOffset { get => base.AutoScrollOffset; set => base.AutoScrollOffset = value; }

        public override LayoutEngine LayoutEngine => base.LayoutEngine;

        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }
        public override Image BackgroundImage { get => base.BackgroundImage; set => base.BackgroundImage = value; }
        public override ImageLayout BackgroundImageLayout { get => base.BackgroundImageLayout; set => base.BackgroundImageLayout = value; }
        public override BindingContext BindingContext { get => base.BindingContext; set => base.BindingContext = value; }
        public override ContextMenu ContextMenu { get => base.ContextMenu; set => base.ContextMenu = value; }
        public override ContextMenuStrip ContextMenuStrip { get => base.ContextMenuStrip; set => base.ContextMenuStrip = value; }
        public override Cursor Cursor { get => base.Cursor; set => base.Cursor = value; }

        public override Rectangle DisplayRectangle => base.DisplayRectangle;

        public override DockStyle Dock { get => base.Dock; set => base.Dock = value; }

        public override bool Focused => base.Focused;

        public override Size MaximumSize { get => base.MaximumSize; set => base.MaximumSize = value; }
        public override Size MinimumSize { get => base.MinimumSize; set => base.MinimumSize = value; }
        public override ISite Site { get => base.Site; set => base.Site = value; }
        public override bool AllowDrop { get => base.AllowDrop; set => base.AllowDrop = value; }
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }
        public override Font Font { get => base.Font; set => base.Font = value; }
        public override RightToLeft RightToLeft { get => base.RightToLeft; set => base.RightToLeft = value; }
        public override string Text { get => base.Text; set => base.Text = value; }

        protected override bool CanRaiseEvents => base.CanRaiseEvents;

        protected override Cursor DefaultCursor => base.DefaultCursor;

        protected override Padding DefaultMargin => base.DefaultMargin;

        protected override Size DefaultMaximumSize => base.DefaultMaximumSize;

        protected override Size DefaultMinimumSize => base.DefaultMinimumSize;

        protected override Padding DefaultPadding => base.DefaultPadding;

        protected override bool DoubleBuffered { get => base.DoubleBuffered; set => base.DoubleBuffered = value; }

        protected override bool ScaleChildren => base.ScaleChildren;

        protected override bool ShowKeyboardCues => base.ShowKeyboardCues;

        protected override bool ShowFocusCues => base.ShowFocusCues;

        protected override bool CanEnableIme => base.CanEnableIme;

        protected override ImeMode ImeModeBase { get => base.ImeModeBase; set => base.ImeModeBase = value; }

        protected override CreateParams CreateParams => base.CreateParams;

        protected override ImeMode DefaultImeMode => base.DefaultImeMode;

        protected override Size DefaultSize => base.DefaultSize;

        public override ObjRef CreateObjRef(Type requestedType)
        {
            return base.CreateObjRef(requestedType);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            return base.GetPreferredSize(proposedSize);
        }

        public override object InitializeLifetimeService()
        {
            return base.InitializeLifetimeService();
        }

        public override bool PreProcessMessage(ref Message msg)
        {
            return base.PreProcessMessage(ref msg);
        }

        public override void Refresh()
        {
            base.Refresh();
        }

        public override void ResetBackColor()
        {
            base.ResetBackColor();
        }

        public override void ResetCursor()
        {
            base.ResetCursor();
        }

        public override void ResetFont()
        {
            base.ResetFont();
        }

        public override void ResetForeColor()
        {
            base.ResetForeColor();
        }

        public override void ResetRightToLeft()
        {
            base.ResetRightToLeft();
        }

        public override void ResetText()
        {
            base.ResetText();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override AccessibleObject CreateAccessibilityInstance()
        {
            return base.CreateAccessibilityInstance();
        }

        protected override ControlCollection CreateControlsInstance()
        {
            return base.CreateControlsInstance();
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();
        }

        protected override void DefWndProc(ref Message m)
        {
            base.DefWndProc(ref m);
        }

        protected override void DestroyHandle()
        {
            base.DestroyHandle();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override AccessibleObject GetAccessibilityObjectById(int objectId)
        {
            return base.GetAccessibilityObjectById(objectId);
        }

        protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified)
        {
            return base.GetScaledBounds(bounds, factor, specified);
        }

        protected override object GetService(Type service)
        {
            return base.GetService(service);
        }

        protected override void InitLayout()
        {
            base.InitLayout();
        }

        protected override bool IsInputChar(char charCode)
        {
            return base.IsInputChar(charCode);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            return base.IsInputKey(keyData);
        }

        protected override void NotifyInvalidate(Rectangle invalidatedArea)
        {
            base.NotifyInvalidate(invalidatedArea);
        }

        protected override void OnAutoSizeChanged(EventArgs e)
        {
            base.OnAutoSizeChanged(e);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
        }

        protected override void OnBackgroundImageChanged(EventArgs e)
        {
            base.OnBackgroundImageChanged(e);
        }

        protected override void OnBackgroundImageLayoutChanged(EventArgs e)
        {
            base.OnBackgroundImageLayoutChanged(e);
        }

        protected override void OnBindingContextChanged(EventArgs e)
        {
            base.OnBindingContextChanged(e);
        }

        protected override void OnCausesValidationChanged(EventArgs e)
        {
            base.OnCausesValidationChanged(e);
        }

        protected override void OnChangeUICues(UICuesEventArgs e)
        {
            base.OnChangeUICues(e);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        protected override void OnClientSizeChanged(EventArgs e)
        {
            base.OnClientSizeChanged(e);
        }

        protected override void OnContextMenuChanged(EventArgs e)
        {
            base.OnContextMenuChanged(e);
        }

        protected override void OnContextMenuStripChanged(EventArgs e)
        {
            base.OnContextMenuStripChanged(e);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        protected override void OnCursorChanged(EventArgs e)
        {
            base.OnCursorChanged(e);
        }

        protected override void OnDockChanged(EventArgs e)
        {
            base.OnDockChanged(e);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
        }

        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            base.OnDragDrop(drgevent);
        }

        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            base.OnDragEnter(drgevent);
        }

        protected override void OnDragLeave(EventArgs e)
        {
            base.OnDragLeave(e);
        }

        protected override void OnDragOver(DragEventArgs drgevent)
        {
            base.OnDragOver(drgevent);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
        {
            base.OnGiveFeedback(gfbevent);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
        }

        protected override void OnHelpRequested(HelpEventArgs hevent)
        {
            base.OnHelpRequested(hevent);
        }

        protected override void OnImeModeChanged(EventArgs e)
        {
            base.OnImeModeChanged(e);
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
        }

        protected override void OnLoadCompleted(AsyncCompletedEventArgs e)
        {
            base.OnLoadCompleted(e);
        }

        protected override void OnLoadProgressChanged(ProgressChangedEventArgs e)
        {
            base.OnLoadProgressChanged(e);
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
        }

        protected override void OnMarginChanged(EventArgs e)
        {
            base.OnMarginChanged(e);
        }

        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            base.OnMouseCaptureChanged(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
        }

        protected override void OnNotifyMessage(Message m)
        {
            base.OnNotifyMessage(m);
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
        }

        protected override void OnParentBackgroundImageChanged(EventArgs e)
        {
            base.OnParentBackgroundImageChanged(e);
        }

        protected override void OnParentBindingContextChanged(EventArgs e)
        {
            base.OnParentBindingContextChanged(e);
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
        }

        protected override void OnParentCursorChanged(EventArgs e)
        {
            base.OnParentCursorChanged(e);
        }

        protected override void OnParentEnabledChanged(EventArgs e)
        {
            base.OnParentEnabledChanged(e);
        }

        protected override void OnParentFontChanged(EventArgs e)
        {
            base.OnParentFontChanged(e);
        }

        protected override void OnParentForeColorChanged(EventArgs e)
        {
            base.OnParentForeColorChanged(e);
        }

        protected override void OnParentRightToLeftChanged(EventArgs e)
        {
            base.OnParentRightToLeftChanged(e);
        }

        protected override void OnParentVisibleChanged(EventArgs e)
        {
            base.OnParentVisibleChanged(e);
        }

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            base.OnPreviewKeyDown(e);
        }

        protected override void OnPrint(PaintEventArgs e)
        {
            base.OnPrint(e);
        }

        protected override void OnQueryContinueDrag(QueryContinueDragEventArgs qcdevent)
        {
            base.OnQueryContinueDrag(qcdevent);
        }

        protected override void OnRegionChanged(EventArgs e)
        {
            base.OnRegionChanged(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnRightToLeftChanged(EventArgs e)
        {
            base.OnRightToLeftChanged(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        protected override void OnSizeModeChanged(EventArgs e)
        {
            base.OnSizeModeChanged(e);
        }

        protected override void OnStyleChanged(EventArgs e)
        {
            base.OnStyleChanged(e);
        }

        protected override void OnSystemColorsChanged(EventArgs e)
        {
            base.OnSystemColorsChanged(e);
        }

        protected override void OnTabIndexChanged(EventArgs e)
        {
            base.OnTabIndexChanged(e);
        }

        protected override void OnTabStopChanged(EventArgs e)
        {
            base.OnTabStopChanged(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }

        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override bool ProcessDialogChar(char charCode)
        {
            return base.ProcessDialogChar(charCode);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            return base.ProcessDialogKey(keyData);
        }

        protected override bool ProcessKeyEventArgs(ref Message m)
        {
            return base.ProcessKeyEventArgs(ref m);
        }

        protected override bool ProcessKeyMessage(ref Message m)
        {
            return base.ProcessKeyMessage(ref m);
        }

        protected override bool ProcessKeyPreview(ref Message m)
        {
            return base.ProcessKeyPreview(ref m);
        }

        protected override bool ProcessMnemonic(char charCode)
        {
            return base.ProcessMnemonic(charCode);
        }

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            base.ScaleControl(factor, specified);
        }

        protected override void ScaleCore(float dx, float dy)
        {
            base.ScaleCore(dx, dy);
        }

        protected override void Select(bool directed, bool forward)
        {
            base.Select(directed, forward);
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, height, specified);
        }

        protected override void SetClientSizeCore(int x, int y)
        {
            base.SetClientSizeCore(x, y);
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(value);
        }

        protected override Size SizeFromClientSize(Size clientSize)
        {
            return base.SizeFromClientSize(clientSize);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        #endregion

    }
}
