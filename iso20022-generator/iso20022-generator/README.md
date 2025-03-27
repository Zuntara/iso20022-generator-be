﻿The iso20022-generator is a c# library which helps you generating iso 20022 artifacts with the minimum amount of information you need to set up valid documents.

What you can do at the moment:
- Currently the creation of pain.001 files is the only thing the library can do.
- The file can contain multiple transactions to different receivers.
- You can add multiple payment information records with multiple transactions each. Each with its different execution date.

Limitations:
- Although the iso20022 is a standard definition it looks as there are a lot of excess to this standard in the world. The library was mainly built for communication with swiss banks. To be precise the library was successfully tested against the test environments from the following banks: Raiffeisen Bank Schweiz, Credit Suisse, UBS and Zürcher Kantonalbank

Usage:
Have a look into the test file

