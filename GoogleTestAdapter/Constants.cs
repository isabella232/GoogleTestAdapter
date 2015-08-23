﻿namespace GoogleTestAdapter
{
    class Constants
    {
        public const bool DEBUG_MODE = false;

        public const string identifierUri = "executor://GoogleTestRunner/v1";
        public const string gtestListTests = "--gtest_list_tests";
        public const string gtestTestBodySignature = "::TestBody";
    }
}