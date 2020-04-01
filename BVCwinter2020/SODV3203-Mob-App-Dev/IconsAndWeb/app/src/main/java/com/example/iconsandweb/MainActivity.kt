package com.example.iconsandweb

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.inputmethod.EditorInfo
import android.webkit.WebView
import android.webkit.WebViewClient
import kotlinx.android.synthetic.main.activity_main.*
import org.jetbrains.anko.webView

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        webView.apply{
            settings.javaScriptEnabled = true
            webViewClient = WebViewClient()
        }

        webView.loadUrl("https://www.google.ca")

        urlText.setOnEditorActionListener { textView, i, keyEvent ->
            if(i == EditorInfo.IME_ACTION_NEXT || i == EditorInfo.IME_ACTION_NEXT){
                webView.loadUrl(urlText.text.toString())
                true
            }else{
                false
            }
        }
    }


    override fun onBackPressed(){
        if(webView.canGoBack())
        {
            webView.goBack()
        }else{
            super.onBackPressed()
        }
    }



}
