﻿open Fix44.Fields
open Fix44.Messages
open Fix44.MsgWriters
open Fix44.CompoundItems

open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running

open BenchmarkDotNet.Configs
open BenchmarkDotNet.Diagnosers
open BenchmarkDotNet.Jobs

//private class Config : ManualConfig
//{
//    public Config()
//    {
//        Add(MemoryDiagnoser.Default);
//        Add(new InliningDiagnoser());
//    }
//}


//type MyConfig () as this =
//    inherit ManualConfig()
//    do
////        let md:IDiagnoser = BenchmarkDotNet.Diagnosers.MemoryDiagnoser() :> IDiagnoser
//        let cd:IDiagnoser = BenchmarkDotNet.Diagnosers.CompositeDiagnoser() :> IDiagnoser
//        this.Add cd






let localMktDate = LocalMktDate.MakeLocalMktDate(2017,01,22)
let monthYear = MonthYear.MakeMonthYear.Make(2017,01,MonthYear.W1)
let utcTimeStamp = UTCDateTime.MakeUTCTimestamp.Make(2017, 01, 22, 06, 54, 00)

let instrument: Instrument =
     {Symbol = (Fix44.Fields.Symbol "RSWQE")
      SymbolSfx = Some WhenIssued
      SecurityID = Some (SecurityID "FJXY")
      SecurityIDSource = Some SecurityIDSource.Valoren
      NoSecurityAltIDGrp = Some []
      Product = None
      CFICode = Some (CFICode "WAUIJ")
      SecurityType = Some TreasuryInflationProtectedSecurities
      SecuritySubType = Some (SecuritySubType "JXYCWAL")
      MaturityMonthYear = Some (MaturityMonthYear monthYear)
      MaturityDate = Some (MaturityDate localMktDate)
      PutOrCall = Some PutOrCall.Put
      CouponPaymentDate = Some (CouponPaymentDate localMktDate)
      IssueDate = None
      //RepoCollateralSecurityType = Some (RepoCollateralSecurityType "0") // quickfixJ
      RepoCollateralSecurityType = Some (RepoCollateralSecurityType 0)
      RepurchaseTerm = Some (RepurchaseTerm 1)
      RepurchaseRate = Some (RepurchaseRate -5534023222112865484.7M)
      Factor = Some (Factor 79228162477.370849433239945M)
      CreditRating = Some (CreditRating "ESTXRVJK")
      InstrRegistry = Some (InstrRegistry "YSWHLF")
      CountryOfIssue = Some (CountryOfIssue "IMGKYZT")
      StateOrProvinceOfIssue = None
      LocaleOfIssue = Some (LocaleOfIssue "VZNO")
      RedemptionDate = Some (RedemptionDate localMktDate)
      StrikePrice = Some (StrikePrice 79228162458924105376.710262785M)
      StrikeCurrency = Some (StrikeCurrency "CWKL")
      OptAttribute = Some (OptAttribute '4')
      ContractMultiplier = Some (ContractMultiplier -3689348814312413.5939M)
      CouponRate = Some (CouponRate -792281.625142643375807M)
      SecurityExchange = None
      Issuer = Some (Issuer "GHBFTU")
      EncodedIssuer ="aa"B |> NonEmptyByteArray.Make |> EncodedIssuer |> Some
      SecurityDesc = Some (SecurityDesc "QUOJDHBP")
      EncodedSecurityDesc = "aa"B |> NonEmptyByteArray.Make |> EncodedSecurityDesc |> Some
      Pool = Some (Pool "DRSWQEF")
      ContractSettlMonth = None
      CPProgram = Some (CPProgram -2)
      CPRegType = Some (CPRegType "UVZTX")
      NoEventsGrp = Some []
      DatedDate = Some (DatedDate localMktDate)
      InterestAccrualDate = Some (InterestAccrualDate localMktDate )
      }

// automatically generated by fscheck, hence the rather wacky values
let newOrderMultileg:NewOrderMultileg =
   {ClOrdID = ClOrdID "PZXWQ"
    SecondaryClOrdID = Some (SecondaryClOrdID "EFZDRSMQ")
    ClOrdLinkID = None
    Parties = {NoPartyIDsGrp = Some []}
    TradeOriginationDate = Some (TradeOriginationDate localMktDate)
    TradeDate = Some (TradeDate localMktDate)
    Account = Some (Account "PKNOIWA")
    AcctIDSource = Some Tfm
    AccountType = Some AccountType.AccountIsCarriedOnNonCustomerSideOfBooks
    DayBookingInst = Some CanTriggerBookingWithoutReferenceToTheOrderInitiator
    BookingUnit = Some AggregatePartialExecutionsOnThisOrderAndBookOneTradePerOrder
    PreallocMethod = None
    AllocID = Some (AllocID "ZNOSMQBF")
    NewOrderMultilegNoAllocsGrp = Some []
    SettlType = Some TPlus5
    SettlDate = Some (SettlDate localMktDate)
    CashMargin = Some MarginOpen
    ClearingFeeIndicator = Some Firms106hAnd106j
    HandlInst = Some ManualOrder
    ExecInst = None
    MinQty = Some (MinQty 792281624589241053767102627.85M)
    MaxFloor = Some (MaxFloor 3.689348814312414M)
    ExDestination = Some (ExDestination "UYJN")
    NoTradingSessionsGrp = Some []
    ProcessCode = Some Regular
    Side = Lend
    Instrument = instrument
    NoUnderlyingsGrp = None
    PrevClosePx = Some (PrevClosePx -7922816249581759353.2719300611M)
    NewOrderMultilegNoLegsGrp = []
    LocateReqd = Some (LocateReqd false)
    TransactTime = TransactTime utcTimeStamp
    QtyType = Some Contracts
    OrderQtyData =
     {OrderQty = None
      CashOrderQty = Some (CashOrderQty -0.000000003689349M)
      OrderPercent = Some (OrderPercent -5534.023223401355674M)
      RoundingDirection = Some RoundDown
      RoundingModulus = Some (RoundingModulus 792281.624958175935327M)}
    OrdType = NextFundValuationPoint
    PriceType = None
    Price = Some (Fix44.Fields.Price 36.893488143124136M)
    StopPx = Some (StopPx 79228162477370849459009.748992M)
    Currency = Some (Fix44.Fields.Currency "USD")
    ComplianceID = Some (ComplianceID "NHVWAUY")
    SolicitedFlag = Some (SolicitedFlag true)
    //IOIID = Some (IOIID "ALPJNB") // quickfixJ
    IOIid = Some (IOIid "ALPJNB") // quickfixN
    QuoteID = Some (QuoteID "KOCDXBP")
    TimeInForce = None
    EffectiveTime =
     Some (EffectiveTime utcTimeStamp)
    ExpireDate = Some (ExpireDate localMktDate)
    ExpireTime = Some (ExpireTime utcTimeStamp)
    GTBookingInst = Some AccumulateUntilVerballyNotifiedOtherwise
    CommissionData = {Commission = Some (Commission -79228.162495817593533M)
                      CommType = Some PercentageWaivedCashDiscount
                      CommCurrency = Some (CommCurrency "VZTHIMGU")
                      FundRenewWaiv = Some No}
    OrderCapacity = None
    OrderRestrictions = Some ForeignEntity
    CustOrderCapacity = Some AllOther
    ForexReq = Some (ForexReq true)
    SettlCurrency = Some (SettlCurrency "ZTXLMG")
    BookingType = Some RegularBooking
    Text = Some (Fix44.Fields.Text "MGBVZT")
    EncodedText = "aa"B |> NonEmptyByteArray.Make |> EncodedText |> Some
    PositionEffect = Some Close
    CoveredOrUncovered = Some Covered
    MaxShow = Some (MaxShow -792281.624773708494590M)
    PegInstructions =
     {PegOffsetValue = Some (PegOffsetValue -79228162477370849.454714781696M)
      PegMoveType = None
      PegOffsetType = Some PegOffsetType.BasisPoints
      PegLimitType = Some PegLimitType.OrWorse
      PegRoundDirection = Some PegRoundDirection.MorePassive
      PegScope = Some PegScope.Local}
    DiscretionInstructions =
     {DiscretionInst = Some RelatedToVwap
      DiscretionOffsetValue =
       Some (DiscretionOffsetValue -79228162514264337580659048.449M)
      DiscretionMoveType = Some Fixed
      DiscretionOffsetType = Some Price
      DiscretionLimitType = Some OrBetter
      DiscretionRoundDirection = Some MoreAggressive
      DiscretionScope = Some Local}
    TargetStrategy = Some (TargetStrategy -3)
    TargetStrategyParameters = Some (TargetStrategyParameters "UOSMHBFZ")
    ParticipationRate = Some (ParticipationRate -55.340232221128655M)
    CancellationRights = Some NoExecutionOnly
    MoneyLaunderingStatus = Some ExemptBelowTheLimit
    RegistID = Some (RegistID "EFJDHS")
    Designation = None
    MultiLegRptTypeReq = Some ReportByMultilegSecurityAndByInstrumentLegsBelongingToTheMultilegSecurity}

let newOrderMultilegDu = newOrderMultileg |> Fix44.MessageDU.NewOrderMultileg

// todo: put a single def of this function in a common location
let convFieldSep (bb:byte) = 
    match bb with 
    | 124uy -> 1uy
    | n     -> n

// the same NewOrderMultileg in byte array form
let newOrderMultilegBytes = "8=FIX.4.4|9=1491|35=AB|34=99|49=senderCompID|52=20071123-05:30:00.000|56=targetCompID|11=PZXWQ|526=EFZDRSMQ|453=0|229=20170122|75=20170122|1=PKNOIWA|660=3|581=2|589=0|590=1|70=ZNOSMQBF|78=0|63=9|64=20170122|544=2|635=H|21=3|110=792281624589241053767102627.850000000000000|111=3.689348814312414|100=UYJN|386=0|81=0|54=F|55=RSWQE|65=WI|48=FJXY|22=D|454=0|461=WAUIJ|167=TIPS|762=JXYCWAL|200=201701w1|541=20170122|201=0|224=20170122|239=0|226=1|227=-5534023222112865484.700000000000000|228=79228162477.370849433239945|255=ESTXRVJK|543=YSWHLF|470=IMGKYZT|472=VZNO|240=20170122|202=79228162458924105376.710262785000000|947=CWKL|206=4|231=-3689348814312413.593900000000000|223=-792281.625142643375807|106=GHBFTU|348=0|349=|107=QUOJDHBP|350=0|351=|691=DRSWQEF|875=-2|876=UVZTX|864=0|873=20170122|874=20170122|140=-7922816249581759353.271930061100000|555=0|114=N|60=20170122-06:54:00|854=1|152=-0.000000003689349|516=-5534.023223401355674|468=1|469=792281.624958175935327|40=M|44=36.893488143124136|99=79228162477370849459009.748992000000000|15=USD|376=NHVWAUY|377=Y|23=ALPJNB|117=KOCDXBP|168=20170122-06:54:00|432=20170122|126=20170122-06:54:00|427=2|12=-79228.162495817593533|13=4|479=VZTHIMGU|497=N|529=7|582=4|121=Y|120=ZTXLMG|775=0|58=MGBVZT|354=0|355=|77=C|203=0|210=-792281.624773708494590|211=-79228162477370849.454714781696000|836=1|837=2|838=2|840=1|388=6|389=-79228162514264337580659048.449000000000000|841=1|842=0|843=0|844=1|846=1|847=-3|848=UOSMHBFZ|849=-55.340232221128655|480=N|481=1|513=EFJDHS|563=1|10=110|"B |> Array.map convFieldSep

let bufSize = 1024 * 16
let buf:byte array = Array.zeroCreate<byte> bufSize
let tmpBuf:byte array =  Array.zeroCreate<byte> bufSize
let beginString:BeginString = BeginString.BeginString "FIX.4.4"
let senderCompID:SenderCompID = SenderCompID.SenderCompID "senderCompID"
let targetCompID:TargetCompID = TargetCompID.TargetCompID "targetCompID"
let msgSeqNum:MsgSeqNum = MsgSeqNum.MsgSeqNum 99u
let sendingTime:SendingTime = SendingTime.SendingTime (UTCDateTime.readUTCTimestamp "20071123-05:30:00.000"B 0 21)

let fieldPosArr = Array.zeroCreate<FIXBufIndexer.FieldPos> 2048

//http://benchmarkdotnet.org/Configs/Configs.htm
//[<Config("columns=Mean,StdDev,Gen0,Gen1,Gen2,Allocated")>]
type BenchmarkNewOrderMultilegMsgWrite () =
    [<Benchmark>]
    member this.WriteIncHdrTrlr () =
        let posW = MsgReadWrite.WriteMessageDU tmpBuf buf 0 beginString senderCompID targetCompID msgSeqNum sendingTime newOrderMultilegDu
        ()

    [<Benchmark>]
    member this.Write () =
        Fix44.MsgWriters.WriteNewOrderMultileg buf 0 newOrderMultileg |> ignore
        ()


type BenchmarkNewOrderMultilegMsgRead () =
    [<Benchmark(Baseline=true)>]
    member this.ReadIncHdrTrlr () =
        let msg = MsgReadWrite.ReadMessage newOrderMultilegBytes newOrderMultilegBytes.Length
        ()

    [<Benchmark>]
    member this.ReadIncHdrTrlrIndexParam () =
        let msg = MsgReadWrite.ReadMessage2 newOrderMultilegBytes newOrderMultilegBytes.Length fieldPosArr 
        ()

    [<Benchmark>]
    member this.ReadIncHdrTrlrTupleParam () =
        let msg = MsgReadWrite.ReadMessage3 (newOrderMultilegBytes, newOrderMultilegBytes.Length)
        ()

    [<Benchmark>]
    member this.ReadIncHdrTrlrTupleIndexParam () =
        let msg = MsgReadWrite.ReadMessage4 (newOrderMultilegBytes, newOrderMultilegBytes.Length, fieldPosArr)
        ()

    [<Benchmark>]
    member this.Read () =
        let indexEnd = FIXBufIndexer.BuildIndex fieldPosArr newOrderMultilegBytes newOrderMultilegBytes.Length
        let index = FIXBufIndexer.IndexData (indexEnd, fieldPosArr)
        let msg = Fix44.MsgReaders.ReadNewOrderMultileg newOrderMultilegBytes index
        ()



let mkRawData = NonEmptyByteArray.Make >> RawData

let Dst:byte array =  Array.zeroCreate<byte> 2048
let logonMsg:Fix44.Messages.Logon = {
        EncryptMethod = EncryptMethod.NoneOther
        HeartBtInt = HeartBtInt.HeartBtInt 30
        RawData = "some data, some more data"B |> mkRawData |> Option.Some
        ResetSeqNumFlag = ResetSeqNumFlag.ResetSeqNumFlag false |> Option.Some
        NextExpectedMsgSeqNum = NextExpectedMsgSeqNum.NextExpectedMsgSeqNum 99u |> Option.Some
        MaxMessageSize = MaxMessageSize.MaxMessageSize 256u |> Option.Some
        NoMsgTypesGrp = Option.None
        TestMessageIndicator = TestMessageIndicator.TestMessageIndicator true |> Option.Some
        Username = Some (Username "fred blogs")
        Password = Some (Password "s;dlkjf;sdkj")
    }


type BenchmarkWriteLogon () =

    [<Benchmark>]
    member this.WriteLogonMsg () =
        Fix44.MsgWriters.WriteLogon Dst 0 logonMsg |> ignore
        ()


    [<Benchmark>]
    member this.WriteLogonIncHdrTrl () =
        let logonMsgDu = logonMsg |> Fix44.MessageDU.Logon
        let posW = MsgReadWrite.WriteMessageDU tmpBuf buf 0 beginString senderCompID targetCompID msgSeqNum sendingTime logonMsgDu
        ()

        


[<EntryPoint>]
let main argv =
//    BenchmarkRunner.Run<BenchmarkNewOrderMultilegMsgRead>( DefaultConfig.Instance.With(Job.RyuJitX64) ) |> ignore
//    BenchmarkRunner.Run<BenchmarkNewOrderMultilegMsg>() |> ignore

    BenchmarkRunner.Run<BenchmarkWriteLogon>(DefaultConfig.Instance.With(Job.RyuJitX64)) |> ignore
    0










