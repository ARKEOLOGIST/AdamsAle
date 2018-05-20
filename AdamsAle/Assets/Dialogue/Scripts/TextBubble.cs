﻿/*
 * MIT License
 * 
 * Copyright (c) 2018 Mathias Wagner Nielsen
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace Dialogue
{
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// Implementation of <see cref="DialogueDisplay"/> which uses a <see cref="UnityEngine.UI.Text"/> component.
    /// </summary>
    public sealed class TextBubble : DialogueDisplay
    {
        [SerializeField]
        private Text display;

        public override string Text
        {
            get { return this.display.text; }
            set { this.display.text = value; }
        }

        private void Reset()
        {
            this.display = this.GetComponentInChildren<Text>();
        }

        public override void Open()
        {
            this.gameObject.SetActive(true);
        }

        public override void Close()
        {
            this.gameObject.SetActive(false);
        }
    }
}