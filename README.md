# ilm_autotrader_ib
Automated trading strategy for Interactive Brokers (IB) TWS platform

Written for Windows .net framework.

Program communicates via IB TWS software platform API.  
Takes market data, process it to make trading decision and generate entry/exit signals.

Trades S&P500 e-mini futures. 1 to 5 trades a week on average.  
Holding period intraday and up to 4 days maximum. 
No position over the weekends.
