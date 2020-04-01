package com.example.march30


import android.view.View
import android.view.ViewGroup
import androidx.test.espresso.Espresso.onView
import androidx.test.espresso.action.ViewActions.*
import androidx.test.espresso.matcher.ViewMatchers.*
import androidx.test.filters.LargeTest
import androidx.test.rule.ActivityTestRule
import androidx.test.runner.AndroidJUnit4
import org.hamcrest.Description
import org.hamcrest.Matcher
import org.hamcrest.Matchers.allOf
import org.hamcrest.TypeSafeMatcher
import org.junit.Rule
import org.junit.Test
import org.junit.runner.RunWith

@LargeTest
@RunWith(AndroidJUnit4::class)
class MainActivityTest {

    @Rule
    @JvmField
    var mActivityTestRule = ActivityTestRule(MainActivity::class.java)

    @Test
    fun mainActivityTest() {
        val appCompatEditText = onView(
            allOf(
                withId(R.id.userLogin), withText("Name"),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    0
                ),
                isDisplayed()
            )
        )
        appCompatEditText.perform(click())

        val appCompatEditText2 = onView(
            allOf(
                withId(R.id.userLogin), withText("Name"),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    0
                ),
                isDisplayed()
            )
        )
        appCompatEditText2.perform(click())

        val appCompatEditText3 = onView(
            allOf(
                withId(R.id.userLogin), withText("Name"),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    0
                ),
                isDisplayed()
            )
        )
        appCompatEditText3.perform(replaceText("sco"))

        val appCompatEditText4 = onView(
            allOf(
                withId(R.id.userLogin), withText("sco"),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    0
                ),
                isDisplayed()
            )
        )
        appCompatEditText4.perform(closeSoftKeyboard())

        val appCompatEditText5 = onView(
            allOf(
                withId(R.id.passLogin),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    2
                ),
                isDisplayed()
            )
        )
        appCompatEditText5.perform(click())

        val appCompatEditText6 = onView(
            allOf(
                withId(R.id.userLogin), withText("sco"),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    0
                ),
                isDisplayed()
            )
        )
        appCompatEditText6.perform(replaceText("scott"))

        val appCompatEditText7 = onView(
            allOf(
                withId(R.id.userLogin), withText("scott"),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    0
                ),
                isDisplayed()
            )
        )
        appCompatEditText7.perform(closeSoftKeyboard())

        val appCompatEditText8 = onView(
            allOf(
                withId(R.id.passLogin),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    2
                ),
                isDisplayed()
            )
        )
        appCompatEditText8.perform(replaceText("12"), closeSoftKeyboard())

        val appCompatEditText9 = onView(
            allOf(
                withId(R.id.passLogin), withText("12"),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    2
                ),
                isDisplayed()
            )
        )
        appCompatEditText9.perform(pressImeActionButton())

        val appCompatEditText10 = onView(
            allOf(
                withId(R.id.passLogin), withText("12"),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    2
                ),
                isDisplayed()
            )
        )
        appCompatEditText10.perform(pressImeActionButton())

        val appCompatEditText11 = onView(
            allOf(
                withId(R.id.passLogin), withText("12"),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    2
                ),
                isDisplayed()
            )
        )
        appCompatEditText11.perform(pressImeActionButton())

        val appCompatButton = onView(
            allOf(
                withId(R.id.login), withText("LOGIN"),
                childAtPosition(
                    childAtPosition(
                        withId(android.R.id.content),
                        0
                    ),
                    1
                ),
                isDisplayed()
            )
        )
        appCompatButton.perform(click())

        val appCompatButton2 = onView(
            allOf(
                withId(android.R.id.button1), withText("Okay"),
                childAtPosition(
                    childAtPosition(
                        withId(R.id.buttonPanel),
                        0
                    ),
                    3
                )
            )
        )
        appCompatButton2.perform(scrollTo(), click())
    }

    private fun childAtPosition(
        parentMatcher: Matcher<View>, position: Int
    ): Matcher<View> {

        return object : TypeSafeMatcher<View>() {
            override fun describeTo(description: Description) {
                description.appendText("Child at position $position in parent ")
                parentMatcher.describeTo(description)
            }

            public override fun matchesSafely(view: View): Boolean {
                val parent = view.parent
                return parent is ViewGroup && parentMatcher.matches(parent)
                        && view == parent.getChildAt(position)
            }
        }
    }
}
