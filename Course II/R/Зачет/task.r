library(rootSolve)
library(corrgram)

# 1.1. ������� ���� dataframe, ���������� ������� � �������� �������
mtcars[ncol(mtcars):1]
# 1.2. ������� ���� dataframe, ������ ������ ������ ��� �������
mtcars[1:3]
# 1.3. ������� ���� dataframe, �������� ���������� �� ������� �������
mtcars[with(mtcars, order(mpg)),]
# 1.4. ������� ���� dataframe, ������ ������ � mpg>20 � carb=2
mtcars[mtcars$mpg > 20 & mtcars$carb == 2,]
# 2.1. ��������� ������� ������, ������������ ������� y=2x-x2; y=-x
y1 <- function(x) 2 * x - x ^ 2;
y2 <- function(x) -x;
(uni <- uniroot.all(y1, c(-10, 10)))
abs(as.numeric(integrate(y2, lower=uni[1], upper=uni[2])$value))- abs(as.numeric(integrate(y1, lower=uni[1], upper=uni[2])$value))
# 3
# 3.1
f1 <- function(x) x / (x ^ 2 + 4)
curve(f1, -5,5)
abline(v=0,lty=3)
abline(h=0,lty=3)
optimize(f1,c(-5,5))
optimize(f1,c(-5,5), maximum = T)
# 3.2
f2 <- function(x) (x ^ 3) * sqrt(x - 1)
curve(f2, -5,10)
abline(v=0, lty=3)
abline(h=0, lty=3)
optimize(f2, c(-10,15))
optimize(f2, c(-10,15), maximum = T)

# 4 ���������
# 4.1.1.���������� ����� � ����������� �������
airquality
boxplot(airquality$Ozone)
# 4.1.2. ��������� �������� Solar.R
airquality$Solar.R
# 4.1.3 ������� �������� ����� Wind
mean(airquality$Wind)
# 4.1.4 ����������� ������������ ������� Temp
airquality$Temp
plot(airquality$Ozone, airquality$Temp)
# 4.1.5 C��������� ����� Ozone
airquality$Ozone
# 4.1.6.�����
airquality$Month
# 4.1.7.����
airquality$Day
# 4.3.1. ������������ ����������
cor(airquality)
# ����������� ����� ��������� � ������ � �������
# 4.3.2. �������������
corrgram(airquality, order=TRUE, lower.panel=panel.shade, upper.panel=panel.pie, text.panel=panel.txt)
# 4.3.3. ���������
summary(lm(Ozone ~ Wind + Temp + Solar.R, airquality))
# ���������� ����� ������� �� ������ ����������: Wind + Temp + Solar.R

# 5.1. ��������� ����� ������ nassCDS.csv
nassCDS <- read.csv('nassCDS.csv')
# 5.2. ��� ������������� ��������� ���������� � �������
nassCDS$frontal <- factor(nassCDS$frontal)
# 5.3. ���������� ������� ������� ������ ���������� � �������������� ���������� �� ����������
head(nassCDS)
xtabs(weight ~ dead + airbag, data=nassCDS)
pairs(nassCDS)
# 5.4. ���������� �� ������� ������� ���������� � �������:
fit <- lm(weight ~ ., nassCDS)
# 6.1 ������� ������������ ���������� �������, ����������� ������������������� �����.
a <- matrix(1:25, nrow = 5, byrow = T)
a
# 6.2 ����������� �������� ���������� ����� ������ � ������������ ����� (row, column) � ������� ������ (�� �����������, ���������)
shift <- function(df, i, j, type = 1) {
  if (type == 1) {
      df <- rbind(df, matrix(ncol = ncol(df), nrow = 1))
      temp <- NA
      for (n_i in i:(ncol(df) + 1)) {
        temp2 <- df[n_i, j]
        df[n_i, j] <- temp
        temp <- temp2
      }
  } else {
      df <- cbind(df, matrix(ncol = 1, nrow = nrow(df)))
      temp <- NA
      for (n_j in j:(nrow(df) + 1)) {
        temp2 <- df[i, n_j]
        df[i, n_j] <- temp
        temp <- temp2
      }
  }
  return (df)
}
# ��������� ��� NA, � ����� ������ ������������ ���, ��� �����. ����������� �� ������ �������
shift(a, 3, 3, 2)
shift(a, 3, 2, 1)
shift(a, 1, 3, 2)


