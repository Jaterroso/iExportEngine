# BaseConditionModel.Evaluate Method (Int32, Int32, FieldValueInformation)
Additional header content 

Returns result of evaluates condition.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public abstract ConditionResult Evaluate(
	int row,
	int col,
	FieldValueInformation target
)
```

**VB**<br />
``` VB
Public MustOverride Function Evaluate ( 
	row As Integer,
	col As Integer,
	target As FieldValueInformation
) As ConditionResult
```


#### Parameters
&nbsp;<dl><dt>row</dt><dd>Type: System.Int32<br />Data row</dd><dt>col</dt><dd>Type: System.Int32<br />Field column</dd><dt>target</dt><dd>Type: <a href="T_iTin_Export_ComponentModel_FieldValueInformation">iTin.Export.ComponentModel.FieldValueInformation</a><br />Field data</dd></dl>

#### Return Value
Type: <a href="T_iTin_Export_Model_ConditionResult">ConditionResult</a><br />A <a href="T_iTin_Export_Model_ConditionResult">ConditionResult</a> object that contains evaluate result.

#### Implements
<a href="M_iTin_Export_Model_ICondition_Evaluate_2">ICondition.Evaluate(Int32, Int32, FieldValueInformation)</a><br />

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.Model.BaseConditionModel.Evaluate(System.Int32,System.Int32,iTin.Export.ComponentModel.FieldValueInformation)"\]

## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel Class</a><br /><a href="Overload_iTin_Export_Model_BaseConditionModel_Evaluate">Evaluate Overload</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />